using System;
using System.Windows.Forms;
using PlcDataCollector.PlcConnection;

namespace PlcDataCollector
{
    static class Program
    {
        public static Variable newVariable;
        public static Plc newPlc;
        public static int timeInterval = 60 * 1000; // 60s * 1000ms = 1min
        public static string backupFileName = "C:\\data\\backup.json";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDataCollector());
        }
    }
}