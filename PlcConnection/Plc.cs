using System.Collections.Generic;
using PlcDataCollector.Database;


namespace PlcDataCollector.PlcConnection
{
    class Plc
    {
        public string ConnectionName { get; set; }

        public OpcConnection OpcConnection { get; set; }

        public AdsConnection AdsConnection { get; set; }

        public Protocol ConnectionProtocol { get; }

        public FileManager FileManager { get; set; }

        public List<Variable> Variables { get; set; }

        public Plc(string connectionName, string address, int port = 851)
        {
            ConnectionName = connectionName;
            ConnectionProtocol = Protocol.ADS;
            AdsConnection = new AdsConnection(address, port);
            FileManager = new FileManager("C:\\Data\\" + connectionName + ".csv");
            Variables = new List<Variable>();
        }

        public void AddVariable(Variable var)
        {
            if (CheckForKnownTypes(var.Type))
                Variables.Add(var);
        }

        public void AddVariable(string type, string name)
        {
            if (CheckForKnownTypes(type))
                Variables.Add(new Variable(type, name));
        }

        private bool CheckForKnownTypes(string type)
        {
            List<string> datatypes = new Datatypes().GetDatatypes();

            foreach (var datatype in datatypes)
            {
                if (datatype.ToUpper().Equals(type.ToUpper()))
                    return true;
            }

            return false;
        }

        public void WriteLine(string text)
        {
            FileManager.FileWriteLine(text);
        }
    }
}