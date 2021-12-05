using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper; // used for "connection.Query<>"

namespace PlcDataCollector.Database
{
    class DatabaseConnection
    {
        /**
         * PLC Data
         */
        public List<PlcConnection.Plc> GetPlc()
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Device").ToList();
            }
        }

        public PlcConnection.Plc GetPlcById(int id)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Device WHERE device_ID = '{id}'").ToList()
                    .ElementAt(0);
            }
        }

        public PlcConnection.Plc GetPlcByName(string name)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Device WHERE device_name = '{name}'")
                    .ToList().ElementAt(0);
            }
        }

        public List<PlcConnection.Plc> GetPlcByConnectionId(int id)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Device WHERE device_Iype_ID = '{id}'")
                    .ToList();
            }
        }

        public PlcConnection.Plc GetPlcByAddress(string address)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Device WHERE device_address = '{address}'")
                    .ToList().ElementAt(0);
            }
        }


        /**
         * TABLE TYPE
         */
        public List<PlcConnection.Plc> GetTypes()
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Type").ToList();
            }
        }

        public PlcConnection.Plc GetTypeById(int id)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Type WHERE type_ID = '{id}'").ToList()
                    .ElementAt(0);
            }
        }

        public PlcConnection.Plc GetTypeByName()
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Type").ToList().ElementAt(0);
            }
        }


        /**
         * TABLE CONNECTION
         */
        public List<PlcConnection.Plc> GetConnections()
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Connections").ToList();
            }
        }

        public PlcConnection.Plc GetConnectionById(int id)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Connections WHERE connection_ID = '{id}'")
                    .ToList().ElementAt(0);
            }
        }

        public PlcConnection.Plc GetConnectionByName(string name)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(DatabaseHelper.ConnectionValue("PlcDatabase")))
            {
                return connection.Query<PlcConnection.Plc>($"SELECT * FROM Connections WHERE name = '{name}'").ToList()
                    .ElementAt(0);
            }
        }
    }
}