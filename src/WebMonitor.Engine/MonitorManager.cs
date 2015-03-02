using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using WebMonitor.Engine.Plugin;
using WebMonitor.Engine.DataStore;

namespace WebMonitor.Engine
{
    public class MonitorManager
    {
        private MonitorPluginManager pluginManager = null;
        private List<Monitor> monitors = null;
        private bool isInitialized = false;

        public MonitorManager()
        {
            pluginManager = new MonitorPluginManager();
            monitors = new List<Monitor>();
        }

        public void Initialize()
        {
            pluginManager.Initialize();
            isInitialized = true;
        }

        public void LoadMonitors()
        {
            monitors = MonitorDataStore.Load();

            //Satisfy the Export/Import attributes (MEF)
            foreach (var monitor in monitors)
                pluginManager.ComposePart(monitor);

            //We have to load in Plugin settings AFTER we satisfied the Exports/Imports
            PluginsDataStore.Load(monitors);
        }

        public void SaveMonitors()
        {
            MonitorDataStore.Save(monitors);
            PluginsDataStore.Save(monitors);
        }

        public Monitor CreateMonitor(string name, string url)
        {
            if (isInitialized)
            {
                Monitor monitor = new Monitor(url);
                pluginManager.ComposePart(monitor); //Satisfy the Export/Import attributes (MEF).
                return monitor;
            }
            else
                throw new Exception("MonitorManager hasn't been initialized!");
        }

        public void PingMonitors()
        {
            foreach (var monitor in monitors)
            {
                monitor.Ping();
            }

            //Save the result of the current "pings"
            HistoryDataStore.Save(monitors);
        }

        public void ClearMonitorList()
        {
            monitors.Clear();
        }

        public void Add(Monitor monitor)
        {
            monitors.Add(monitor);
        }

        public void AddMany(List<Monitor> monitorsToAdd)
        {
            monitors.AddRange(monitorsToAdd);
        }







        #region Properties
        public Monitor[] Monitors
        {
            get { return monitors.ToArray(); }
        }

        public IMonitorPlugin[] Plugins
        {
            get { return pluginManager.Plugins.ToArray(); }
        }
        #endregion Properties
    }
}
