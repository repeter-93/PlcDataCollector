using System.Configuration;

namespace PlcDataCollector.Database
{
    class DatabaseHelper
    {
        public static string ConnectionValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}