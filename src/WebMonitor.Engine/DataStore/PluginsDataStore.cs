using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using WebMonitor.Engine.Plugin;

namespace WebMonitor.Engine.DataStore
{
    internal class PluginsDataStore
    {
        private static string path = "PluginSettings.xml"; //Todo: We might want to have this in some king of config file

        internal static List<Monitor> Load(string filename, List<Monitor> monitors)
        {
            //If the file with all the monitors doesn't exists, we save a empty/clean one
            if (!File.Exists(filename))
                Save(new List<Monitor>());

            XDocument doc = XDocument.Load(filename);

            foreach (var monitor in monitors)
            {
                //Find the pluginsetting for the current Monitor
                var PluginSetting = (from ps in doc.Descendants("PluginSetting")
                                        where ps.Attribute("MonitorId").ToString() == monitor.Id.ToString()
                                        select ps);

                //Find all the plugins, so we can use the values to put into the plugins in the current monitors list
                var specificPluginSettings = (from p in PluginSetting.Descendants("Plugin")
                                                select p);

                foreach (var item in specificPluginSettings)
                {
                    IMonitorPlugin plugin = monitor.Plugins.FirstOrDefault(p => p.Id.ToString() == item.Attribute("Id").ToString());

                    if (plugin != null)
                    {
                        plugin.Enabled = Boolean.Parse(item.Attribute("Enabled").ToString());
                    }
                }                                
            }

            return monitors;
        }

        internal static List<Monitor> Load(List<Monitor> monitors)
        {
            return Load(path, monitors);
        }







        internal static void Save(string filename, List<Monitor> monitors)
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("PluginSettings", (from m in monitors
                                                    select new XElement("PluginSetting",
                                                          new XAttribute("MonitorId", m.Id),
                                                          new XElement("Plugins", (from p in m.Plugins
                                                                                   select new XElement("Plugin",
                                                                                       new XAttribute("Id", p.Id),
                                                                                       new XAttribute("Enabled", p.Enabled))).ToList()
                                                                             )
                                                     )).ToList()
                                )
                    );
            doc.Save(filename);
        }

        internal static void Save(List<Monitor> monitors)
        {
            Save(path, monitors);
        }

       
    }
}
