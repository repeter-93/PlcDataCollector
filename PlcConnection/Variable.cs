namespace PlcDataCollector.PlcConnection
{
    public class Variable
    {
        public Variable()
        {
            Type = null;
            Name = null;
        }

        public Variable(string type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        public string Type { get; set; }

        public string Name { get; set; }
    }
}