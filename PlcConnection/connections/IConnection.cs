namespace PlcDataCollector.PlcConnection
{
    public interface ConnectionInterface
    {
        void Connect();
        void Disconnect();
        string ReadVariable(Variable variable);
        string ReadVariable(string variableName, string variableType);
    }
}