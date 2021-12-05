using System;
using TwinCAT.Ads;
using System.IO;
using System.Windows.Forms;
using PlcDataCollector;
using PlcDataCollector.PlcConnection;

namespace PlcDataCollector.PlcConnection
{
    class AdsConnection : ConnectionInterface
    {
        private ErrorMessageLogger _errorMessageLogger;

        public TcAdsClient TcAdsClient { get; set; }

        public string ConnectionString { get; set; }

        public int ConnectionPort { get; set; }

        public bool DeviceConnected
        {
            get;
            private set;
            //set => deviceConnected = value;
        }

        public AdsConnection(string connectionString, int connectionPort = 851)
        {
            this._errorMessageLogger = new ErrorMessageLogger();
            this.TcAdsClient = new TcAdsClient();
            this.ConnectionString = connectionString;
            this.ConnectionPort = connectionPort;
            this.DeviceConnected = false;
            Connect();
        }

        public void Connect()
        {
            try
            {
                TcAdsClient.Connect(ConnectionString, ConnectionPort);
                DeviceConnected = true;
            }
            catch (Exception exception)
            {
                WriteLogEntry("ADS connection failed", exception);
                MessageBox.Show(
                    "Connection to PLC with Net ID = " + ConnectionString + " failed!",
                    "Connection failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (!DeviceConnected)
                return;

            try
            {
                TcAdsClient.Disconnect();
                DeviceConnected = false;
            }
            catch (Exception exception)
            {
                WriteLogEntry("Disconnect ADS connection failed", exception);
                MessageBox.Show(
                    "Disconnect PLC with Net ID = " + ConnectionString + " failed!",
                    "Disconnect failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public string ReadVariable(Variable variable)
        {
            try
            {
                return ReadVariable(variable.Name, variable.Type);
            }
            catch (Exception exception)
            {
                WriteLogEntry(
                    "Read variable filed (Client: " + TcAdsClient.Address + "; Variable: " + variable.Name + ")",
                    exception);
                return null;
            }
        }

        public string ReadVariable(string variableName, string variableType)
        {
            if (!DeviceConnected)
            {
                WriteLogEntry("Tried to read value without active connection!");
                return null;
            }

            int streamSize = GetStreamSizeByVariableType(variableType);
            if (streamSize > 0)
            {
                AdsStream stream = new AdsStream(streamSize);
                BinaryReader binaryRead = new BinaryReader(stream);

                try
                {
                    int variableHandler = TcAdsClient.CreateVariableHandle(variableName);
                    TcAdsClient.Read(variableHandler, stream);

                    switch (variableType.ToUpper())
                    {
                        case "BYTE": return binaryRead.ReadByte().ToString();
                        case "SINT": return binaryRead.ReadSByte().ToString();
                        case "USINT": return binaryRead.ReadByte().ToString();
                        case "WORD": return binaryRead.ReadUInt16().ToString();
                        case "INT": return binaryRead.ReadInt16().ToString();
                        case "UINT": return binaryRead.ReadUInt16().ToString();
                        case "DWORD": return binaryRead.ReadUInt32().ToString();
                        case "DINT": return binaryRead.ReadInt32().ToString();
                        case "UDINT": return binaryRead.ReadUInt32().ToString();
                        case "REAL": return binaryRead.ReadSingle().ToString();
                        case "LINT": return binaryRead.ReadInt64().ToString();
                        case "ULINT": return binaryRead.ReadUInt64().ToString();
                        case "LREAL": return binaryRead.ReadDouble().ToString();
                        default: return "";
                    }
                }
                catch (TwinCAT.ClientNotConnectedException exception)
                {
                    WriteLogEntry("TwinCAT.ClientNotConnectedException occured", exception);
                }
                catch (EndOfStreamException exception)
                {
                    WriteLogEntry("System.IO.EndOfStreamException occured", exception);
                }
                catch (Exception exception)
                {
                    WriteLogEntry("System.Exception occured", exception);
                }

                return null;
            }
            else
            {
                WriteLogEntry("No available type selected for \"read variable\" (Client: " + TcAdsClient.Address +
                              "; Variable: " + variableName + ")");
            }

            return null;
        }

        private static int GetStreamSizeByVariableType(string type)
        {
            switch (type.ToUpper())
            {
                case "BYTE":
                case "SINT":
                case "USINT":
                    return 1;

                case "WORD":
                case "INT":
                case "UINT":
                    return 2;

                case "DWORD":
                case "DINT":
                case "UDINT":
                case "REAL":
                    return 4;

                case "LINT":
                case "ULINT":
                case "LREAL":
                    return 8;

                default:
                    return 0;
            }
        }

        private void WriteLogEntry(string message, Exception exception = null)
        {
            if (exception == null)
            {
                _errorMessageLogger.WriteLogEntry(DateTime.Now.ToString() + " - " + message);
            }
            else
            {
                _errorMessageLogger.WriteLogEntry(DateTime.Now.ToString() + " - " + message + ": " + exception);
            }
        }
    }
}