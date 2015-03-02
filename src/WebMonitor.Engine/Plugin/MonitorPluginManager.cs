using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.ComponentModel.Composition;

namespace WebMonitor.Engine.Plugin
{
    public class MonitorPluginManager
    {
        private CompositionContainer pluginContainer;

        public MonitorPluginManager()
        {
            Plugins = new List<IMonitorPlugin>();
        }

        public void Initialize()
        {
            if (!Directory.Exists("Plugins")) //Todo: We might want to have the path in a config file
                Directory.CreateDirectory("Plugins");

            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog("Plugins"));
            catalog.Catalogs.Add(new DirectoryCatalog(".")); //This is actually only here for this to work in Test scenarios. As the plugins isn't builded to the /Plugins/ folder.
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(MonitorPluginManager).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

            pluginContainer = new CompositionContainer(catalog);
            ComposePart(this);
        }

        public void ComposePart(object obj)
        {
            pluginContainer.ComposeParts(obj);
        }
        
        #region Properties
        /// <summary>
        /// List of all plugins loaded into the system.
        /// </summary>
        [ImportMany(typeof(IMonitorPlugin))]
        public List<IMonitorPlugin> Plugins { get; internal set; }
        #endregion Properties

    }
}
