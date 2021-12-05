using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using PlcDataCollector.PlcConnection;

namespace PlcDataCollector
{
    public partial class FormDataCollector : Form
    {
        private List<Plc> plcs;
        private Plc selectedPlc;
        private ErrorMessageLogger errorMessageLogger;

        public FormDataCollector()
        {
            InitializeComponent();

            plcs = new List<Plc>();
            selectedPlc = null;

            if (File.Exists(Program.backupFileName))
            {
                // https://stackoverflow.com/questions/16019729/deserializing-json-object-into-a-c-sharp-list
                string jsonString = File.ReadAllText(Program.backupFileName);
                plcs = JsonConvert.DeserializeObject<List<Plc>>(jsonString);
            }

            timerSaveVariables.Interval = Program.timeInterval;
            timerSaveVariables.Enabled = true;
            timerSaveVariables.Start();

            UpdateForm();
        }

        private void listBoxPlcs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxPlcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePlcSelection();
            UpdateForm();
        }

        private void buttonAddPlc_Click(object sender, EventArgs e)
        {
            AddPlcConnection();
            UpdateForm();
        }

        private void buttonDeletePlc_Click(object sender, EventArgs e)
        {
            DeletePlcConnection();
            UpdateForm();
        }

        private void button_Connect(object sender, EventArgs e)
        {
            switch (selectedPlc.ConnectionProtocol)
            {
                case Protocol.OPC:
                    selectedPlc.OpcConnection.Connect();
                    break;
                case Protocol.ADS:
                    selectedPlc.AdsConnection.Connect();
                    break;
                default:
                    break;
            }

            UpdateForm();
        }

        private void button_Disconnect(object sender, EventArgs e)
        {
            switch (selectedPlc.ConnectionProtocol)
            {
                case Protocol.OPC:
                    selectedPlc.OpcConnection.Disconnect();
                    break;
                case Protocol.ADS:
                    selectedPlc.AdsConnection.Disconnect();
                    break;
                default:
                    break;
            }

            UpdateForm();
        }

        private void buttonReadValue_Click(object sender, EventArgs e)
        {
            ReadVariable(selectedPlc);
            UpdateForm();
        }

        private void buttonAddVariable_Click(object sender, EventArgs e)
        {
            AddVariable();
            UpdateForm();
        }

        private void buttonDeleteVariable_Click(object sender, EventArgs e)
        {
            DeleteVariable();
            UpdateForm();
        }

        private void ChangePlcSelection()
        {
            selectedPlc = null;
            foreach (Plc plc in plcs)
            {
                if (plc.ConnectionName.Equals(comboBoxPlcs.Text))
                {
                    selectedPlc = plc;
                    break;
                }
            }
        }

        private void AddPlcConnection()
        {
            Form form = new FormPlcCreator();
            form.ShowDialog();

            if (Program.newPlc == null)
                return;

            foreach (Plc plc in plcs)
            {
                if (Program.newPlc.ConnectionName.Equals(plc.ConnectionName))
                {
                    MessageBox.Show("Connection name already exists!", "Dublicate name", MessageBoxButtons.OK);
                    return;
                }
            }

            plcs.Add(Program.newPlc);
            Program.newPlc = null;
            SaveConnectionData();
        }

        private void DeletePlcConnection()
        {
            if (listBoxPlcs.SelectedItem == null)
                return;

            string selectedElement = listBoxPlcs.SelectedItem.ToString();

            for (var i = 0; i < plcs.Count; i++)
            {
                if (plcs.ElementAt(i).ConnectionName.Equals(selectedElement))
                {
                    plcs.RemoveAt(i);
                    listBoxPlcs.Items.Remove(listBoxPlcs.SelectedItem);
                    break;
                }
            }

            SaveConnectionData();
        }

        private void AddVariable()
        {
            if (selectedPlc == null)
            {
                MessageBox.Show("Select a PLC connection before adding new variables", "No PLC selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form form = new FormVariableCreator();
            form.ShowDialog();

            if (Program.newVariable == null)
                return;

            selectedPlc.Variables.Add(Program.newVariable);
            Program.newVariable = new Variable();

            SaveConnectionData();
        }

        private void DeleteVariable()
        {
            if (selectedPlc == null)
                return;
            if (selectedPlc.Variables.Count <= 0)
                return;

            string selectedElement = listBoxVariables.SelectedItem.ToString();

            for (var i = 0; i < selectedPlc.Variables.Count; i++)
            {
                if (selectedPlc.Variables.ElementAt(i).Name.Equals(selectedElement))
                {
                    selectedPlc.Variables.RemoveAt(i);
                    listBoxVariables.Items.Remove(listBoxVariables.SelectedItem);
                    break;
                }
            }

            SaveConnectionData();
        }

        private void ReadVariable(Plc connectedPlc)
        {
            string values = DateTime.Now.ToString();
            foreach (Variable plcVariable in connectedPlc.Variables)
            {
                values += ";";
                switch (connectedPlc.ConnectionProtocol)
                {
                    case Protocol.OPC:
                        break;
                    case Protocol.ADS:
                        values += connectedPlc.AdsConnection.ReadVariable(plcVariable);
                        break;
                    default:
                        break;
                }
            }

            connectedPlc.WriteLine(values);
        }

        private void UpdatePlcList()
        {
            listBoxPlcs.Items.Clear();
            comboBoxPlcs.Items.Clear();
            foreach (Plc plc in plcs)
            {
                string connectionState;
                bool deviceConnected;

                switch (plc.ConnectionProtocol)
                {
                    case Protocol.OPC:
                        deviceConnected = plc.OpcConnection.DeviceConnected;
                        break;
                    case Protocol.ADS:
                        deviceConnected = plc.AdsConnection.DeviceConnected;
                        break;
                    default:
                        deviceConnected = false;
                        break;
                }

                if (deviceConnected)
                {
                    connectionState = " (connected)";
                }
                else
                {
                    connectionState = " (disconnected)";
                }

                listBoxPlcs.Items.Add(plc.ConnectionName + connectionState);
                comboBoxPlcs.Items.Add(plc.ConnectionName);
            }
        }

        private void UpdateVariableList()
        {
            if (selectedPlc == null)
                return;

            listBoxVariables.Items.Clear();
            foreach (var plcVariable in selectedPlc.Variables)
            {
                listBoxVariables.Items.Add(plcVariable.Name);
            }
        }

        private void UpdateForm()
        {
            UpdatePlcList();
            UpdateVariableList();
        }

        // copied from https://stackoverflow.com/questions/12080697/convert-struct-to-json
        private void SaveConnectionData()
        {
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonString = "";
                jsonString += serializer.Serialize(plcs);
                File.WriteAllText(Program.backupFileName, jsonString);
            }
            catch (Exception exception)
            {
                WriteLogEntry("Error while saving JSON file", exception);
            }
        }

        private void timerSaveVariables_Tick(object sender, EventArgs e)
        {
            foreach (Plc plc in plcs)
            {
                ReadVariable(plc);
            }
        }

        private void WriteLogEntry(string message, Exception exception = null)
        {
            if (exception == null)
            {
                errorMessageLogger.WriteLogEntry(DateTime.Now.ToString() + " - " + message);
            }
            else
            {
                errorMessageLogger.WriteLogEntry(
                    DateTime.Now.ToString() + " - " + message + ": " + exception.ToString());
            }
        }
    }
}