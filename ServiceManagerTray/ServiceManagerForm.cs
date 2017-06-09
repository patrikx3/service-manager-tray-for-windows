using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ServiceProcess;

using chc.servicemanagertray.Properties;
using System.Security.Principal;

namespace chc.servicemanagertray
{
    public partial class ServiceManagerForm : Form
    {
        #region Fields

        /// <summary>
        /// The datasource for the grid that provides the services.
        /// </summary>
        private ServiceDataSource ds;

        /// <summary>
        /// The name of the service currently selected to re-select on refresh and re-bind.
        /// </summary>
        private string instance_selected_service_name = null;

        private FormWindowState mLastState;
        private bool firstSave = true;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes the designer components.
        /// Initializes the form.
        /// </summary>
        public ServiceManagerForm(String[] args)
        {
            InitializeComponent();
            InitializeForm();

            this.servicegrid.CellMouseEnter += Servicegrid_CellMouseEnter;

            if (args.Length == 3)
            {
                bool stopToFalseAndStartToTrue = Boolean.Parse(args[2]);
                var service = (from sw in ds.GetServices() where sw.ServiceController.ServiceName == args[1] select sw).FirstOrDefault();

                if (service != null)
                {
                    if (!stopToFalseAndStartToTrue)
                    {
                        service.Stop();
                    } else
                    {
                        service.Start();
                    }
                    SetStatusUpdateNotificationTimer(service, !stopToFalseAndStartToTrue ? ServiceControllerStatus.Stopped : ServiceControllerStatus.Running, null);
                }

            }
            searchFilter.TextChanged += SearchFilter_TextChanged;
            searchServiceInfo.TextChanged += searchServiceInfo_TextChanged;

            mLastState = this.WindowState;
            this.WindowState = Properties.Settings.Default.FormWindowState;
        }

        private void SearchFilter_TextChanged(object sender, EventArgs e)
        {
            this.ds.Search = searchFilter.Text;
            searchServiceInfo.Text = searchFilter.Text;
            BindServiceData(true);
        }


        private void searchServiceInfo_TextChanged(object sender, EventArgs e)
        {
            this.ds.Search = searchServiceInfo.Text;
            searchFilter.Text = searchServiceInfo.Text;
            BindServiceData(true);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates the datasource, the tray icon and binds the grid,
        /// </summary>
        private void InitializeForm()
        {
#if DEBUG
//            WindowState = FormWindowState.Normal;
#endif
            this.ds = new ServiceDataSource();

            // grid binding
            InitializeGrid();

            BuildTrayMenu();

            System.Reflection.Assembly ass = System.Reflection.Assembly.GetExecutingAssembly();
            statusstrip_statuslabel.Text = string.Concat("v", ass.GetName().Version.ToString());
        }

        /// <summary>
        /// Initializes the grid programmatically (set alternating row style and so on..)
        /// </summary>
        private void InitializeGrid()
        {
            servicegrid.AlternatingRowsDefaultCellStyle.BackColor = servicegrid.DefaultCellStyle.BackColor.ChangeBrightness(-25);
            BindServiceData(true);
            this.servicegrid.Rows[0].Selected = true;
            this.servicegrid.Focus();
        }

        /// <summary>
        /// Builds the tray menu, adds the selected favorite services.
        /// </summary>
        private void BuildTrayMenu()
        {
            var favorites = (from sw in ds.GetServices() where sw.IsFavorite orderby sw.DisplayName descending select sw).ToList<ServiceWrapper>();

            while (this.trayicon_menu.Items.Count > 6)
            {
                this.trayicon_menu.Items.RemoveAt(2);
            }

            if (favorites.Count < 1)
            {
                return;
            }

            foreach (ServiceWrapper sw in favorites)
            {

                var item_service = new ToolStripMenuItem();
                item_service.Text = GetServiceMenuItemText(sw);
                item_service.Tag = sw;
                item_service.Checked = sw.Status == ServiceControllerStatus.Running;
                item_service.ToolTipText = Properties.Resources.NotifyIcon_Menu_FavoriteServicesLabel_Tooltip;
                item_service.Click += delegate(object sender, EventArgs e)
                {
                    var i = sender as ToolStripMenuItem;
                    var swi = i.Tag as ServiceWrapper;
                    if (item_service.Checked)
                    {
                        swi.Stop();
                        if (ServiceManagerForm.IsElevated)
                        {
                            SetStatusUpdateNotificationTimer(swi, ServiceControllerStatus.Stopped, item_service);
                        }
                    }
                    else
                    {
                        swi.Start();
                        if (ServiceManagerForm.IsElevated)
                        {
                            SetStatusUpdateNotificationTimer(swi, ServiceControllerStatus.Running, item_service);
                        }
                    }
                };
                this.trayicon_menu.Items.Insert(1, item_service);
            }
            this.trayicon_menu.Items.Insert(1, new ToolStripSeparator());
            var favorite_label = new ToolStripLabel(Properties.Resources.NotifyIcon_Menu_FavoriteServicesLabel_Text);
            favorite_label.Font = new Font(System.Drawing.SystemFonts.IconTitleFont, FontStyle.Bold);
            favorite_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.trayicon_menu.Items.Insert(2, favorite_label);

        }

        /// <summary>
        /// The service menu item string like [service name] - [service state]
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        private static string GetServiceMenuItemText(ServiceWrapper sw)
        {
            var msg = string.Format(Properties.Resources.NotifyIcon_Menu_Service, sw.DisplayName, sw.Status.ToString());
            return msg;
        }

        /// <summary>
        /// Starts a timer for the specified service
        /// and after the services reached the desired status it refreshes the grid.
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="statusToWaitFor"></param>
        private void SetStatusUpdateNotificationTimer(ServiceWrapper sw, ServiceControllerStatus statusToWaitFor, ToolStripMenuItem item_service)
        {
            if (item_service != null)
            {
                item_service.Enabled = false;
            }
            var refresh = new Timer();
            refresh.Interval = 200;
            refresh.Tick += delegate(object sender2, EventArgs e2)
            {
                sw.ServiceController.Refresh();
                if (sw.ServiceController.Status == statusToWaitFor)
                {
                    if (item_service != null)
                    {
                        item_service.Checked = (sw.ServiceController.Status == ServiceControllerStatus.Running);
                        item_service.Text = GetServiceMenuItemText(sw);
                        item_service.Enabled = true;
                    }
                    ShowServiceState(sw);
                    BindServiceData(false);
                    BuildTrayMenu();
                    refresh.Stop();
                }
            };
            refresh.Start();
        }


        /// <summary>
        /// Displays the service state as a balloon.
        /// </summary>
        /// <param name="sw"></param>
        private void ShowServiceState(ServiceWrapper sw)
        {
            var msg = string.Format(CultureInfo.InvariantCulture, Properties.Resources.NotifyIcon_Baloon_Service_State, sw.DisplayName, sw.Status.ToString().ToLowerInvariant());
            trayicon.ShowBalloonTip(2000, Properties.Resources.NotifyIcon_Baloon_Header, msg, ToolTipIcon.Info);
        }

        /// <summary>
        /// Refreshes the services info and binds the data to the grid.
        /// </summary>
        /// <param name="refresh_services">If TRUE the list of services is refreshed as well.</param>
        private void BindServiceData(bool refresh_services)
        {
            string selected_service_name = this.instance_selected_service_name;

            if (selected_service_name == null)
            {
                selected_service_name = GetSelectedServiceName();
            }

            var list = ds.GetServicesSearched(refresh_services);
            DataGridViewColumn sorted_column = servicegrid.SortedColumn;
            if (sorted_column != null)
            {
                Properties.Settings.Default.SortColumnName = sorted_column.DataPropertyName;
                Properties.Settings.Default.SortOrder = servicegrid.SortOrder;
            }
            else
            {
                sorted_column = (from DataGridViewColumn c in servicegrid.Columns where c.DataPropertyName == Properties.Settings.Default.SortColumnName select c).Single<DataGridViewColumn>();
            }
            var sorting_list = new SortableBindingList<ServiceWrapper>(list);
            this.servicegrid.DataSource = sorting_list;
            if (sorted_column != null)
            {
                servicegrid.Sort(sorted_column, Properties.Settings.Default.SortOrder == SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending);
            }

            if (selected_service_name != null)
            {
                servicegrid.ClearSelection();
                var row = (from DataGridViewRow r in servicegrid.Rows where (r.DataBoundItem as ServiceWrapper).DisplayName == selected_service_name select r).SingleOrDefault<DataGridViewRow>();
                if (row != null)
                {
                    row.Selected = true;
                    servicegrid.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
            servicegrid.Update();
        }

        /// <summary>
        /// Gets the name of the selected service.
        /// </summary>
        /// <returns></returns>
        private string GetSelectedServiceName()
        {
            string selected_service_name = null;
            if (servicegrid.SelectedRows.Count > 0)
            {
                selected_service_name = (servicegrid.SelectedRows[0].DataBoundItem as ServiceWrapper).DisplayName;
            }
            return selected_service_name;
        }

        /// <summary>
        /// If the window is minimized it will hidden in the tray.
        /// </summary>
        private void SetTaskbarState()
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.ShowInTaskbar = false;

                if (!Properties.Settings.Default.TrayBalloonShown)
                {
                    this.trayicon.ShowBalloonTip(5000, Properties.Resources.NotifyIcon_Baloon_Header, Properties.Resources.NotifyIcon_Baloon_Hide, ToolTipIcon.Info);
                    Properties.Settings.Default.TrayBalloonShown = true;
                }
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        public static bool IsElevated
        {
            get
            {
                WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
                return hasAdministrativeRight;
            }
        }

        public static void RequestElevatation(String serviceName, bool falseIsToStopAndTrueIsToStart)
        {

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = Application.ExecutablePath;
            processInfo.Arguments = serviceName + " " + falseIsToStopAndTrueIsToStart.ToString();
            try
            {
                Process.Start(processInfo);
            }
            catch (Win32Exception)
            {
                return;
            }
            Application.Exit();
        }

        #endregion

        #region Commands
        /// <summary>
        /// Displays the form.
        /// </summary>
        private void ShowForm()
        {
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Saves the settings and quits.
        /// </summary>
        public void QuitForm()
        {
            SaveSettings();

            Application.Exit();
        }

        /// <summary>
        /// Saves the grid sort settings into the program settings.
        /// </summary>
        private void SaveGridSortState()
        {
            if (servicegrid.SortedColumn != null)
            {
                Properties.Settings.Default.SortColumnName = servicegrid.SortedColumn.DataPropertyName;
                Properties.Settings.Default.SortOrder = servicegrid.SortOrder;
            }
        }

        /// <summary>
        /// Saves settings.
        /// Save grid sort state.
        /// </summary>
        private void SaveSettings()
        {
            SaveGridSortState();
            Properties.Settings.Default.Save();

//            MessageBox.Show("Save: " + Properties.Settings.Default.FormWindowState.ToString());
        }


        /// <summary>
        /// Minimizes the form.
        /// </summary>
        private void MinimizeForm()
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Shows or hides the main form based on the visibility (toggle).
        /// </summary>
        private void ToggleFormDisplay()
        {
            if (WindowState != FormWindowState.Minimized)
            {
                MinimizeForm();
            }
            else
            {
                ShowForm();
            }
            Properties.Settings.Default.FormWindowState = this.WindowState;
            SaveSettings();
        }


        private void RefreshGrid()
        {
            BindServiceData(true);
        }

        #endregion

        #region Events

        /// <summary>
        /// When the form is resized, the taskbar state is set.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceManagerForm_Resize(object sender, EventArgs e)
        {
            SetTaskbarState();
        }


        /// <summary>
        /// When the form is closed, it is minimized instead so that it is hidden in the tray.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
//            MessageBox.Show(e.CloseReason.ToString());
            switch (e.CloseReason)
            {
                case CloseReason.WindowsShutDown:
                case CloseReason.ApplicationExitCall:
                    break;
            
                default:
                    e.Cancel = true;
                    WindowState = FormWindowState.Minimized;
                    break;
            }
            /*
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            } 
            */
        }

        #endregion

        #region Tray Icon Menu Events

        /// <summary>
        /// On left mouse click, show the service manager on the tray icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trayicon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToggleFormDisplay();
            }
        }

        /// <summary>
        /// Show the service manager on the tray menu item click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trayicon_menu_servicemanager_Click(object sender, EventArgs e)
        {
            ToggleFormDisplay();
        }

        /// <summary>
        /// When exit is clicked the quit method is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trayicon_menu_exit_Click(object sender, EventArgs e)
        {
            QuitForm();
        }

        #endregion

        #region Main menu events


        /// <summary>
        /// About menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainmenu_help_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(global::chc.servicemanagertray.Properties.Resources.About_Text, global::chc.servicemanagertray.Properties.Resources.About_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Options menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainmenu_tools_option_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented at the moment.", global::chc.servicemanagertray.Properties.Resources.About_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Grid Events

        private void Servicegrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            servicegrid.Cursor = Cursors.Default;
            switch (e.ColumnIndex)
            {
                case 2:
                case 3:
                case 4:
                    servicegrid.Cursor = Cursors.Hand;
                    break;

                default:
                    servicegrid.Cursor = Cursors.Default;
                    break;
            }
        }

        /// <summary>
        /// Renders the info panel contents on the left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicegrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (servicegrid.CurrentRow != null)
            {
                ServiceWrapper sw = servicegrid.CurrentRow.DataBoundItem as ServiceWrapper;
                infopanel_name.Text = sw.ServiceController.DisplayName;
                infopanel_description.Text = sw.Description;

            }
        }


        /// <summary>
        /// Selects the service row on right click also.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicegrid_MouseDown(object sender, MouseEventArgs e)
        {
            // Sets is so the right-mousedown will select a cell
            DataGridView.HitTestInfo hti = servicegrid.HitTest(e.X, e.Y);

            if (hti.RowIndex == -1)
            {
                return;
            }

            // Clear all the previously selected rows
            servicegrid.ClearSelection();

            // Set as selected
            servicegrid.Rows[hti.RowIndex].Selected = true;
        }


        /// <summary>
        /// Updates the ui to make a service favorita or start/stop on the gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = servicegrid.Rows[e.RowIndex];
            var sw = row.DataBoundItem as ServiceWrapper;

            switch (row.Cells[e.ColumnIndex].OwningColumn.DataPropertyName)
            {
                case "IsFavorite":
                    sw.IsFavorite = !sw.IsFavorite;
                    this.BuildTrayMenu();
                    SaveSettings();
                    break;

                case "Status":
                case "IsRunning":
                    ToolStripMenuItem menu_item = null;
                    bool new_state = !sw.IsRunning;
                    sw.IsRunning = new_state;

                    if (IsElevated)
                    {
                        SetStatusUpdateNotificationTimer(sw, new_state ? ServiceControllerStatus.Running : ServiceControllerStatus.Stopped, menu_item);

                        // find corresponding tray menu item
                        foreach (ToolStripItem item in trayicon_menu.Items)
                        {
                            menu_item = item as ToolStripMenuItem;
                            if (menu_item != null && menu_item.Tag == sw)
                            {
                                break;
                            }
                            menu_item = null;
                        }
                        break;
                    }
                    break;
            }
        }
        #endregion

        #region Generic Command Events

        /// <summary>
        /// Generic refresh command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generic_refreshbutton_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }


        /// <summary>
        /// Generic exit command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generic_exit_Click(object sender, EventArgs e)
        {
            QuitForm();
        }
        #endregion

        protected override void OnClientSizeChanged(EventArgs e)
        {
            if (this.WindowState != mLastState)
            {
                mLastState = this.WindowState;
                OnWindowStateChanged(e);
            }
            base.OnClientSizeChanged(e);
        }
        protected void OnWindowStateChanged(EventArgs e)
        {
            if (firstSave)
            {
                firstSave = false;
                return;
            }
            Properties.Settings.Default.FormWindowState = this.WindowState;
        }

        #region Tool Strip Events

        /// <summary>
        /// Starts the windows service manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolstrip_winservicemanager_Click(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        /// <summary>
        /// Starts the windows task manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolstrip_taskmanager_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");

        }


        #endregion
    }
}
