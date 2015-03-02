using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMonitor.Engine
{
    public class MonitorPingResult
    {
        internal MonitorPingResult()
        {
            Succeeded = false;
            Error = null;
        }

        /// <summary>
        /// Indicates weather the request for the web server were a success or not.
        /// </summary>
        public bool Succeeded { get; set; }
        public Exception Error { get; set; }
    }
}
