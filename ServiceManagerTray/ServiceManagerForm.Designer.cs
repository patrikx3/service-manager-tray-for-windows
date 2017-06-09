namespace chc.servicemanagertray
{
    partial class ServiceManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trayicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayicon_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayicon_menu_servicemanager = new System.Windows.Forms.ToolStripMenuItem();
            this.trayicon_menu_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayicon_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusstrip = new System.Windows.Forms.StatusStrip();
            this.statusstrip_statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.mainmenu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu_tools_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenurefresh_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainmenu_tools_option = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.servicegrid = new System.Windows.Forms.DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.servicegrid_namecolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicegrid_statuscolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicegrid_favoritecolumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicegrid_isrunningcolumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicegrid_contextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.servicegrid_contextmenu_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.servicegrid_bindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.toolstrip_refreshbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstrip_winservicemanager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstrip_taskmanager = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.splitcontainer = new System.Windows.Forms.SplitContainer();
            this.infopanel_table = new System.Windows.Forms.TableLayoutPanel();
            this.infopanel_name = new System.Windows.Forms.Label();
            this.infopanel_description = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchServiceInfo = new System.Windows.Forms.TextBox();
            this.trayicon_menu.SuspendLayout();
            this.statusstrip.SuspendLayout();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicegrid)).BeginInit();
            this.servicegrid_contextmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicegrid_bindingsource)).BeginInit();
            this.toolstrip.SuspendLayout();
            this.contentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).BeginInit();
            this.splitcontainer.Panel1.SuspendLayout();
            this.splitcontainer.Panel2.SuspendLayout();
            this.splitcontainer.SuspendLayout();
            this.infopanel_table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayicon
            // 
            this.trayicon.BalloonTipText = "Service Manager Tray";
            this.trayicon.ContextMenuStrip = this.trayicon_menu;
            this.trayicon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayicon.Icon")));
            this.trayicon.Text = "Service Manager Tray";
            this.trayicon.Visible = true;
            this.trayicon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayicon_MouseClick);
            // 
            // trayicon_menu
            // 
            this.trayicon_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.trayicon_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayicon_menu_servicemanager,
            this.trayicon_menu_separator1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.trayicon_menu_exit});
            this.trayicon_menu.Name = "contextMenuStrip1";
            this.trayicon_menu.Size = new System.Drawing.Size(300, 136);
            // 
            // trayicon_menu_servicemanager
            // 
            this.trayicon_menu_servicemanager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trayicon_menu_servicemanager.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.trayicon_menu_servicemanager.Image = ((System.Drawing.Image)(resources.GetObject("trayicon_menu_servicemanager.Image")));
            this.trayicon_menu_servicemanager.Name = "trayicon_menu_servicemanager";
            this.trayicon_menu_servicemanager.Size = new System.Drawing.Size(299, 30);
            this.trayicon_menu_servicemanager.Text = "&Service Manager";
            this.trayicon_menu_servicemanager.Click += new System.EventHandler(this.trayicon_menu_servicemanager_Click);
            // 
            // trayicon_menu_separator1
            // 
            this.trayicon_menu_separator1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trayicon_menu_separator1.Name = "trayicon_menu_separator1";
            this.trayicon_menu_separator1.Size = new System.Drawing.Size(296, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(299, 30);
            this.toolStripMenuItem2.Text = "Task manager";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolstrip_taskmanager_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(299, 30);
            this.toolStripMenuItem1.Text = "Windows service manager";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolstrip_winservicemanager_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(296, 6);
            // 
            // trayicon_menu_exit
            // 
            this.trayicon_menu_exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.trayicon_menu_exit.Image = ((System.Drawing.Image)(resources.GetObject("trayicon_menu_exit.Image")));
            this.trayicon_menu_exit.Name = "trayicon_menu_exit";
            this.trayicon_menu_exit.Size = new System.Drawing.Size(299, 30);
            this.trayicon_menu_exit.Text = "E&xit";
            this.trayicon_menu_exit.Click += new System.EventHandler(this.trayicon_menu_exit_Click);
            // 
            // statusstrip
            // 
            this.statusstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusstrip_statuslabel});
            this.statusstrip.Location = new System.Drawing.Point(0, 679);
            this.statusstrip.Name = "statusstrip";
            this.statusstrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusstrip.Size = new System.Drawing.Size(1094, 30);
            this.statusstrip.TabIndex = 7;
            this.statusstrip.Text = "statusStrip";
            // 
            // statusstrip_statuslabel
            // 
            this.statusstrip_statuslabel.Name = "statusstrip_statuslabel";
            this.statusstrip_statuslabel.Size = new System.Drawing.Size(142, 25);
            this.statusstrip_statuslabel.Text = "Service Manager";
            // 
            // mainmenu
            // 
            this.mainmenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenu_file,
            this.mainmenu_tools,
            this.mainmenu_help});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainmenu.Size = new System.Drawing.Size(1094, 35);
            this.mainmenu.TabIndex = 9;
            this.mainmenu.Text = "Service Manager Menu";
            // 
            // mainmenu_file
            // 
            this.mainmenu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenu_file_exit});
            this.mainmenu_file.Name = "mainmenu_file";
            this.mainmenu_file.Size = new System.Drawing.Size(50, 29);
            this.mainmenu_file.Text = "&File";
            // 
            // mainmenu_file_exit
            // 
            this.mainmenu_file_exit.Image = ((System.Drawing.Image)(resources.GetObject("mainmenu_file_exit.Image")));
            this.mainmenu_file_exit.Name = "mainmenu_file_exit";
            this.mainmenu_file_exit.Size = new System.Drawing.Size(123, 30);
            this.mainmenu_file_exit.Text = "E&xit";
            this.mainmenu_file_exit.Click += new System.EventHandler(this.generic_exit_Click);
            // 
            // mainmenu_tools
            // 
            this.mainmenu_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenu_tools_refresh,
            this.mainmenurefresh_separator1,
            this.mainmenu_tools_option});
            this.mainmenu_tools.Name = "mainmenu_tools";
            this.mainmenu_tools.Size = new System.Drawing.Size(65, 29);
            this.mainmenu_tools.Text = "&Tools";
            // 
            // mainmenu_tools_refresh
            // 
            this.mainmenu_tools_refresh.Image = ((System.Drawing.Image)(resources.GetObject("mainmenu_tools_refresh.Image")));
            this.mainmenu_tools_refresh.Name = "mainmenu_tools_refresh";
            this.mainmenu_tools_refresh.Size = new System.Drawing.Size(160, 30);
            this.mainmenu_tools_refresh.Text = "&Refresh";
            this.mainmenu_tools_refresh.Click += new System.EventHandler(this.generic_refreshbutton_Click);
            // 
            // mainmenurefresh_separator1
            // 
            this.mainmenurefresh_separator1.Name = "mainmenurefresh_separator1";
            this.mainmenurefresh_separator1.Size = new System.Drawing.Size(157, 6);
            // 
            // mainmenu_tools_option
            // 
            this.mainmenu_tools_option.Image = ((System.Drawing.Image)(resources.GetObject("mainmenu_tools_option.Image")));
            this.mainmenu_tools_option.Name = "mainmenu_tools_option";
            this.mainmenu_tools_option.Size = new System.Drawing.Size(160, 30);
            this.mainmenu_tools_option.Text = "&Options";
            this.mainmenu_tools_option.Click += new System.EventHandler(this.mainmenu_tools_option_Click);
            // 
            // mainmenu_help
            // 
            this.mainmenu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenu_help_about});
            this.mainmenu_help.Name = "mainmenu_help";
            this.mainmenu_help.Size = new System.Drawing.Size(61, 29);
            this.mainmenu_help.Text = "&Help";
            // 
            // mainmenu_help_about
            // 
            this.mainmenu_help_about.Image = ((System.Drawing.Image)(resources.GetObject("mainmenu_help_about.Image")));
            this.mainmenu_help_about.Name = "mainmenu_help_about";
            this.mainmenu_help_about.Size = new System.Drawing.Size(158, 30);
            this.mainmenu_help_about.Text = "&About...";
            this.mainmenu_help_about.Click += new System.EventHandler(this.mainmenu_help_about_Click);
            // 
            // servicegrid
            // 
            this.servicegrid.AllowUserToAddRows = false;
            this.servicegrid.AllowUserToDeleteRows = false;
            this.servicegrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.servicegrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.servicegrid.AutoGenerateColumns = false;
            this.servicegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicegrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.servicegrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.servicegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicegrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.servicegrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.servicegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.servicegrid_namecolumn,
            this.servicegrid_statuscolumn,
            this.servicegrid_favoritecolumn,
            this.servicegrid_isrunningcolumn});
            this.servicegrid.ContextMenuStrip = this.servicegrid_contextmenu;
            this.servicegrid.DataSource = this.servicegrid_bindingsource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.servicegrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.servicegrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicegrid.Location = new System.Drawing.Point(0, 0);
            this.servicegrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 34);
            this.servicegrid.MultiSelect = false;
            this.servicegrid.Name = "servicegrid";
            this.servicegrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.servicegrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.servicegrid.RowHeadersVisible = false;
            this.servicegrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.servicegrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicegrid.ShowEditingIcon = false;
            this.servicegrid.Size = new System.Drawing.Size(842, 612);
            this.servicegrid.TabIndex = 10;
            this.servicegrid.VirtualMode = true;
            this.servicegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicegrid_CellClick);
            this.servicegrid.CurrentCellChanged += new System.EventHandler(this.servicegrid_CurrentCellChanged);
            this.servicegrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.servicegrid_MouseDown);
            // 
            // icon
            // 
            this.icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.icon.FillWeight = 5F;
            this.icon.HeaderText = "";
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.MinimumWidth = 16;
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.icon.Width = 16;
            // 
            // servicegrid_namecolumn
            // 
            this.servicegrid_namecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.servicegrid_namecolumn.DataPropertyName = "DisplayName";
            this.servicegrid_namecolumn.FillWeight = 50F;
            this.servicegrid_namecolumn.HeaderText = "Name";
            this.servicegrid_namecolumn.MinimumWidth = 200;
            this.servicegrid_namecolumn.Name = "servicegrid_namecolumn";
            this.servicegrid_namecolumn.ReadOnly = true;
            this.servicegrid_namecolumn.Width = 300;
            // 
            // servicegrid_statuscolumn
            // 
            this.servicegrid_statuscolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.servicegrid_statuscolumn.DataPropertyName = "Status";
            this.servicegrid_statuscolumn.FillWeight = 15F;
            this.servicegrid_statuscolumn.HeaderText = "Status";
            this.servicegrid_statuscolumn.MinimumWidth = 70;
            this.servicegrid_statuscolumn.Name = "servicegrid_statuscolumn";
            this.servicegrid_statuscolumn.ReadOnly = true;
            this.servicegrid_statuscolumn.Width = 70;
            // 
            // servicegrid_favoritecolumn
            // 
            this.servicegrid_favoritecolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.servicegrid_favoritecolumn.DataPropertyName = "IsFavorite";
            this.servicegrid_favoritecolumn.FillWeight = 15F;
            this.servicegrid_favoritecolumn.HeaderText = "Favorite";
            this.servicegrid_favoritecolumn.MinimumWidth = 70;
            this.servicegrid_favoritecolumn.Name = "servicegrid_favoritecolumn";
            this.servicegrid_favoritecolumn.ReadOnly = true;
            this.servicegrid_favoritecolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.servicegrid_favoritecolumn.Width = 70;
            // 
            // servicegrid_isrunningcolumn
            // 
            this.servicegrid_isrunningcolumn.DataPropertyName = "IsRunning";
            this.servicegrid_isrunningcolumn.FillWeight = 15F;
            this.servicegrid_isrunningcolumn.HeaderText = "Start/stop";
            this.servicegrid_isrunningcolumn.MinimumWidth = 70;
            this.servicegrid_isrunningcolumn.Name = "servicegrid_isrunningcolumn";
            this.servicegrid_isrunningcolumn.ReadOnly = true;
            this.servicegrid_isrunningcolumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // servicegrid_contextmenu
            // 
            this.servicegrid_contextmenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.servicegrid_contextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicegrid_contextmenu_refresh});
            this.servicegrid_contextmenu.Name = "servicegrid_contextmenu";
            this.servicegrid_contextmenu.Size = new System.Drawing.Size(151, 34);
            // 
            // servicegrid_contextmenu_refresh
            // 
            this.servicegrid_contextmenu_refresh.Image = ((System.Drawing.Image)(resources.GetObject("servicegrid_contextmenu_refresh.Image")));
            this.servicegrid_contextmenu_refresh.Name = "servicegrid_contextmenu_refresh";
            this.servicegrid_contextmenu_refresh.Size = new System.Drawing.Size(150, 30);
            this.servicegrid_contextmenu_refresh.Text = "Refresh";
            this.servicegrid_contextmenu_refresh.Click += new System.EventHandler(this.generic_refreshbutton_Click);
            // 
            // servicegrid_bindingsource
            // 
            this.servicegrid_bindingsource.DataMember = "Services";
            this.servicegrid_bindingsource.DataSource = typeof(chc.servicemanagertray.ServiceDataSource);
            // 
            // toolstrip
            // 
            this.toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_refreshbutton,
            this.toolStripSeparator1,
            this.toolstrip_winservicemanager,
            this.toolStripSeparator2,
            this.toolstrip_taskmanager,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.searchFilter,
            this.toolStripSeparator5,
            this.toolStripButton1});
            this.toolstrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolstrip.Size = new System.Drawing.Size(1094, 32);
            this.toolstrip.TabIndex = 15;
            this.toolstrip.Text = "toolStrip1";
            // 
            // toolstrip_refreshbutton
            // 
            this.toolstrip_refreshbutton.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_refreshbutton.Image")));
            this.toolstrip_refreshbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_refreshbutton.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.toolstrip_refreshbutton.Name = "toolstrip_refreshbutton";
            this.toolstrip_refreshbutton.Size = new System.Drawing.Size(98, 29);
            this.toolstrip_refreshbutton.Text = "&Refresh";
            this.toolstrip_refreshbutton.Click += new System.EventHandler(this.generic_refreshbutton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolstrip_winservicemanager
            // 
            this.toolstrip_winservicemanager.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_winservicemanager.Image")));
            this.toolstrip_winservicemanager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_winservicemanager.Name = "toolstrip_winservicemanager";
            this.toolstrip_winservicemanager.Size = new System.Drawing.Size(247, 29);
            this.toolstrip_winservicemanager.Text = "Windows &service manager";
            this.toolstrip_winservicemanager.Click += new System.EventHandler(this.toolstrip_winservicemanager_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolstrip_taskmanager
            // 
            this.toolstrip_taskmanager.Image = ((System.Drawing.Image)(resources.GetObject("toolstrip_taskmanager.Image")));
            this.toolstrip_taskmanager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstrip_taskmanager.Name = "toolstrip_taskmanager";
            this.toolstrip_taskmanager.Size = new System.Drawing.Size(148, 29);
            this.toolstrip_taskmanager.Text = "&Task manager";
            this.toolstrip_taskmanager.Click += new System.EventHandler(this.toolstrip_taskmanager_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 29);
            this.toolStripLabel1.Text = "Search services:";
            // 
            // searchFilter
            // 
            this.searchFilter.Name = "searchFilter";
            this.searchFilter.Size = new System.Drawing.Size(100, 32);
            this.searchFilter.ToolTipText = "You might search in the services";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 29);
            this.toolStripButton1.Text = "E&xit";
            this.toolStripButton1.Click += new System.EventHandler(this.generic_exit_Click);
            // 
            // contentpanel
            // 
            this.contentpanel.Controls.Add(this.splitcontainer);
            this.contentpanel.Controls.Add(this.toolstrip);
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(0, 35);
            this.contentpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1094, 644);
            this.contentpanel.TabIndex = 16;
            // 
            // splitcontainer
            // 
            this.splitcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitcontainer.Location = new System.Drawing.Point(0, 32);
            this.splitcontainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitcontainer.Name = "splitcontainer";
            // 
            // splitcontainer.Panel1
            // 
            this.splitcontainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitcontainer.Panel1.Controls.Add(this.infopanel_table);
            // 
            // splitcontainer.Panel2
            // 
            this.splitcontainer.Panel2.Controls.Add(this.servicegrid);
            this.splitcontainer.Size = new System.Drawing.Size(1094, 612);
            this.splitcontainer.SplitterDistance = 246;
            this.splitcontainer.SplitterWidth = 6;
            this.splitcontainer.TabIndex = 17;
            // 
            // infopanel_table
            // 
            this.infopanel_table.ColumnCount = 1;
            this.infopanel_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infopanel_table.Controls.Add(this.infopanel_name, 0, 0);
            this.infopanel_table.Controls.Add(this.infopanel_description, 0, 1);
            this.infopanel_table.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.infopanel_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infopanel_table.Location = new System.Drawing.Point(0, 0);
            this.infopanel_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infopanel_table.Name = "infopanel_table";
            this.infopanel_table.RowCount = 3;
            this.infopanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.infopanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infopanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infopanel_table.Size = new System.Drawing.Size(246, 612);
            this.infopanel_table.TabIndex = 1;
            // 
            // infopanel_name
            // 
            this.infopanel_name.AutoEllipsis = true;
            this.infopanel_name.AutoSize = true;
            this.infopanel_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infopanel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infopanel_name.Location = new System.Drawing.Point(4, 9);
            this.infopanel_name.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.infopanel_name.Name = "infopanel_name";
            this.infopanel_name.Size = new System.Drawing.Size(238, 40);
            this.infopanel_name.TabIndex = 0;
            this.infopanel_name.Text = "[name]";
            // 
            // infopanel_description
            // 
            this.infopanel_description.AutoEllipsis = true;
            this.infopanel_description.AutoSize = true;
            this.infopanel_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infopanel_description.Location = new System.Drawing.Point(4, 49);
            this.infopanel_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infopanel_description.Name = "infopanel_description";
            this.infopanel_description.Size = new System.Drawing.Size(238, 487);
            this.infopanel_description.TabIndex = 1;
            this.infopanel_description.Text = "[description]";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchServiceInfo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 541);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 66);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search services";
            // 
            // searchServiceInfo
            // 
            this.searchServiceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchServiceInfo.Location = new System.Drawing.Point(4, 25);
            this.searchServiceInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchServiceInfo.Name = "searchServiceInfo";
            this.searchServiceInfo.Size = new System.Drawing.Size(229, 26);
            this.searchServiceInfo.TabIndex = 1;
            // 
            // ServiceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 709);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.statusstrip);
            this.Controls.Add(this.mainmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceManagerForm";
            this.ShowInTaskbar = false;
            this.Text = "Service Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceManagerForm_FormClosing);
            this.Resize += new System.EventHandler(this.ServiceManagerForm_Resize);
            this.trayicon_menu.ResumeLayout(false);
            this.statusstrip.ResumeLayout(false);
            this.statusstrip.PerformLayout();
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicegrid)).EndInit();
            this.servicegrid_contextmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicegrid_bindingsource)).EndInit();
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.contentpanel.ResumeLayout(false);
            this.contentpanel.PerformLayout();
            this.splitcontainer.Panel1.ResumeLayout(false);
            this.splitcontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitcontainer)).EndInit();
            this.splitcontainer.ResumeLayout(false);
            this.infopanel_table.ResumeLayout(false);
            this.infopanel_table.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayicon;
        private System.Windows.Forms.ContextMenuStrip trayicon_menu;
        private System.Windows.Forms.ToolStripMenuItem trayicon_menu_exit;
        private System.Windows.Forms.ToolStripMenuItem trayicon_menu_servicemanager;
        private System.Windows.Forms.BindingSource servicegrid_bindingsource;
        private System.Windows.Forms.ToolStripSeparator trayicon_menu_separator1;
        private System.Windows.Forms.StatusStrip statusstrip;
        private System.Windows.Forms.ToolStripStatusLabel statusstrip_statuslabel;
        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_file;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_tools;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_tools_option;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_help;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_help_about;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem mainmenu_tools_refresh;
        private System.Windows.Forms.ToolStripSeparator mainmenurefresh_separator1;
        private System.Windows.Forms.DataGridView servicegrid;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton toolstrip_refreshbutton;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.SplitContainer splitcontainer;
        private System.Windows.Forms.ToolStripButton toolstrip_winservicemanager;
        private System.Windows.Forms.TableLayoutPanel infopanel_table;
        private System.Windows.Forms.Label infopanel_name;
        private System.Windows.Forms.Label infopanel_description;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolstrip_taskmanager;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip servicegrid_contextmenu;
        private System.Windows.Forms.ToolStripMenuItem servicegrid_contextmenu_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicegrid_namecolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicegrid_statuscolumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn servicegrid_favoritecolumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn servicegrid_isrunningcolumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox searchFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchServiceInfo;
    }
}

