using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.ServiceProcess;

namespace chc.servicemanagertray
{
    
    /// <summary>
    /// Service data store.
    /// </summary>
    internal class ServiceDataSource
    {

        /// <summary>
        /// List of services.
        /// </summary>
        private List<ServiceWrapper> services;

        private string search = null;

        public string Search {
            set
            {
                search = value;
            }
            get
            {
                return search;
            }
        }

        /// <summary>
        /// Get the list of services on localhost
        /// </summary>
        public List<ServiceWrapper> GetServices(bool refresh_services = false)
        {
            if (this.services == null)
            {
                LoadServices();
            }
            if (refresh_services)
            {
                Refresh();
            }

            return services;
        }

        public List<ServiceWrapper> GetServicesSearched(bool refresh_services = false)
        {
            var services = GetServices(refresh_services);
            services = (from ServiceWrapper s in this.services where String.IsNullOrWhiteSpace(search) || s.DisplayName.ToLower().Contains(search.ToLower()) || s.Description.ToLower().Contains(search.ToLower()) select s).ToList();

            return services;
        }

        public List<ServiceWrapper> Services
        {
            get
            {
                return GetServices();
            }
        }

        public void Refresh()
        {
            services.ForEach(delegate(ServiceWrapper s)
            {
                s.ServiceController.Refresh();
            });
        }

        private void LoadServices()
        {
            services = new List<ServiceWrapper>();
            foreach (ServiceController s in from s in ServiceController.GetServices() orderby s.DisplayName ascending select s)
            {
                ServiceWrapper sw = new ServiceWrapper(s, Properties.Settings.Default.Favorites.Contains(s.ServiceName));
                services.Add(sw);
            }
        }

    }

}
