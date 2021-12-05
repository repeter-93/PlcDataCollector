using System.Collections.Generic;

namespace PlcDataCollector.PlcConnection
{
    public class Datatypes
    {
        public List<string> GetDatatypes()
        {
            List<string> datatypes = new List<string>();
            datatypes.Add("BYTE");
            datatypes.Add("SINT");
            datatypes.Add("USINT");
            datatypes.Add("WORD");
            datatypes.Add("INT");
            datatypes.Add("UINT");
            datatypes.Add("DWORD");
            datatypes.Add("DINT");
            datatypes.Add("UDINT");
            datatypes.Add("REAL");
            datatypes.Add("LINT");
            datatypes.Add("ULINT");
            datatypes.Add("LREAL");
            return datatypes;
        }
    }
}