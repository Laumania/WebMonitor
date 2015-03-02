using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebMonitor.Engine;

namespace WebMonitor.Test
{
    public static class HelperMethods
    {

        public static void FillMonitorList(MonitorManager monitorManager)
        {
            monitorManager.AddMany(GenerateMonitorList());
        }

        public static List<Monitor> GenerateMonitorList()
        {
            return GenerateMonitorList(4);
        }

        public static List<Monitor> GenerateMonitorList(int amount)
        {
            List<Monitor> list = new List<Monitor>();
            MonitorManager manager = new MonitorManager();
            manager.Initialize();

            for (int i = 0; i < amount; i++)
            {
                Monitor m = manager.CreateMonitor("Test_" + i, "http://laumania.net");
                m.Name = "Test monitor no. " + i;
                list.Add(m);
            }

            return list;
        }
    }
}
