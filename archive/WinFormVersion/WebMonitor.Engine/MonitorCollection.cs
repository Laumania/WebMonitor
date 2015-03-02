using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WebMonitor.Engine
{
    public class MonitorCollection : List<Monitor>
    {
        public MonitorCollection()
        {
        }

        public Monitor GetMonitor(string id)
        {
            return this.FirstOrDefault(m => m.Id.ToString() == id);
        }
    }
}
