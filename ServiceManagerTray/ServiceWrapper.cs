using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.ServiceProcess;
using System.Management;

namespace chc.servicemanagertray
{/// <summary>
 /// Decorates the ServiceController.
 /// </summary>
    internal class ServiceWrapper
    {
        /// <summary>
        /// Favoroite field, fovaorites are displayed on the context menu of the notify icon.
        /// </summary>
        private bool favorite = false;

        /// <summary>
        /// Consturcts a new service wrapper.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="isFavorite"></param>
        public ServiceWrapper(ServiceController service, bool isFavorite)
        {
            this.ServiceController = service;
            this.favorite = isFavorite;
            LoadDescription();
        }

        private void LoadDescription()
        {
            ManagementObject wmiService;
            wmiService = new ManagementObject("Win32_Service.Name='" + ServiceController.ServiceName + "'");
            wmiService.Get();

            Description = wmiService["Description"] == null ? "" : wmiService["Description"].ToString();
        }

        /// <summary>
        /// The description of the service in the registry
        /// </summary>
        public string Description
        {
            get;
            private set;
        }


        /// <summary>
        /// Property for favrotie.
        /// </summary>
        public bool IsFavorite
        {
            get
            {
                return this.favorite;
            }
            set
            {
                if (!value)
                {
                    Properties.Settings.Default.Favorites.Remove(this.ServiceController.ServiceName);
                }
                else
                {
                    Properties.Settings.Default.Favorites.Add(this.ServiceController.ServiceName);
                }
                favorite = value;
            }
        }

        /// <summary>
        /// Property for is running, changing the state stops/starts the service.
        /// </summary>
        public bool IsRunning
        {
            get
            {
                return this.ServiceController.Status == ServiceControllerStatus.Running;
            }
            set
            {
                if (value)
                {
                    this.Start();
                }
                else
                {
                    this.Stop();
                }

            }

        }

        /// <summary>
        /// Starts, stops the service.
        /// </summary>
        public void Start()
        {
            if (!ServiceManagerForm.IsElevated)
            {
                ServiceManagerForm.RequestElevatation(ServiceController.ServiceName, true);
                return;
            }
            ServiceController.Refresh();
            if (ServiceController.Status == ServiceControllerStatus.Stopped)
            {
                ServiceController.Start();
            }
            else
            {

            }
        }

        /// <summary>
        /// Stops the service.
        /// </summary>
        public void Stop()
        {
            if (!ServiceManagerForm.IsElevated)
            {
                ServiceManagerForm.RequestElevatation(ServiceController.ServiceName, false);
                return;
            }
            ServiceController.Refresh();
            if (ServiceController.Status == ServiceControllerStatus.Running)
            {
                ServiceController.Stop();
            }
        }

        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName
        {
            get
            {
                return this.ServiceController.DisplayName;
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        public ServiceControllerStatus Status
        {
            get
            {
                return this.ServiceController.Status;
            }
        }

        /// <summary>
        /// The service controllers.
        /// </summary>
        public ServiceController ServiceController
        {
            get;
            private set;
        }
    }

}
