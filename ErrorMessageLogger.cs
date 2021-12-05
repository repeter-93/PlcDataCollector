using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcDataCollector
{
    public class ErrorMessageLogger
    {
        public void WriteLogEntry(string logEntry)
        {
            System.Diagnostics.Debug.Write(logEntry);
            System.Diagnostics.Trace.Write(logEntry);
        }
    }
}