using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using WebMonitor.Engine.Plugin;

namespace WebMonitor.Engine.DataStore
{
    internal class MonitorDataStore
    {
        private static string path = "Monitors.xml"; //Todo: We might want to have this in some king of config file

        internal static List<Monitor> Load(string filename)
        {
            //If the file with all the monitors doesn't exists, we save a empty/clean one
            if (!File.Exists(filename))
                Save(new List<Monitor>());

            XDocument doc = XDocument.Load(filename);
            var result = from m in doc.Descendants("Monitor")
                         select new Monitor()
                         {
                             Id = new Guid(m.Attribute("Id").Value),
                             Url = m.Element("Url").Value,
                             Name = m.Element("Name").Value
                         };

            return result.ToList();
        }

        internal static List<Monitor> Load()
        {
            return Load(path);
        }


        internal static void Save(IList<Monitor> monitors, string filename)
        {
            XDocument doc = new XDocument();
            doc.Add(new XElement("Monitors", (from m in monitors
                                              select new XElement("Monitor",
                                              new XAttribute("Id", m.Id),
                                              new XElement("Url", m.Url),
                                              new XElement("Name", m.Name)
                                             )).ToList()
                                )
                    );
            doc.Save(filename);
        }

        internal static void Save(List<Monitor> monitors)
        {
            Save(monitors, path);
        }
    }
}
