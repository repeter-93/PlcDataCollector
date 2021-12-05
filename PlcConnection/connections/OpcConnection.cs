namespace PlcDataCollector.PlcConnection
{
    public class OpcConnection : ConnectionInterface
    {
        public void Connect()
        {
            throw new System.NotImplementedException();
        }

        public void Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public string ReadVariable(Variable variable)
        {
            throw new System.NotImplementedException();
        }

        public string ReadVariable(string variableName, string variableType)
        {
            throw new System.NotImplementedException();
        }
        
        public bool DeviceConnected { get; private set; }
    }
}