using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace WebMonitor.Engine.DataStore
{
    // History in this case is data from "previous" pings, which can be loaded up and used later on
    internal class HistoryDataStore
    {
        private static string path = "{0}.xml"; //Todo: We might want to have this in some king of config file
        private static string dir = "Data";

        internal static void Save(IList<Monitor> monitors, string filename)
        {
            string todaysFileName = string.Format(dir +"/" +path, DateTime.Now.ToShortDateString());
            XDocument doc = new XDocument();

            //Make sure we have the folder and file we need
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            if (!File.Exists(todaysFileName))
            {
                doc.Add(new XElement("History", GenerateHistoryElement(monitors)));
                doc.Save(todaysFileName);
            }
            else
            {
                doc = XDocument.Load(todaysFileName);
                doc.Root.Add(GenerateHistoryElement(monitors));
                doc.Save(todaysFileName);
            }
        }

        internal static void Save(IList<Monitor> monitors)
        {
            Save(monitors, path);
        }


        #region Private Methods
        private static IList<XElement> GenerateHistoryElement(IList<Monitor> monitors)
        {
            return (from m in monitors
                         select new XElement("Monitor",
                         new XAttribute("Id", m.Id),
                         new XAttribute("DateTime", DateTime.Now.ToString()),
                         new XElement("PluginResults",
                         (from p in m.Plugins
                          select new XElement("PluginResult",
                              new XAttribute("Id", p.Id),
                              new XElement("Result", p.PingResult))
                         ).ToList()))
                                                ).ToList();
        }
        #endregion Private Methods
    }
}
