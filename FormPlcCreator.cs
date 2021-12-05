using System.Windows.Forms;
using PlcDataCollector.PlcConnection;

namespace PlcDataCollector
{
  public partial class FormPlcCreator : Form
  {
    public FormPlcCreator()
    {
      InitializeComponent();
    }

    private void buttonPlcCreatorOk_Click(object sender, System.EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxPlcCreatorName.Text))
      {
        MessageBox.Show("Insert connection name.", "No connection name", MessageBoxButtons.OK);
        return;
      }

      if (string.IsNullOrEmpty(textBoxPlcCreatorIp.Text))
      {
        MessageBox.Show("Insert connection IP address.", "No IP address", MessageBoxButtons.OK);
        return;
      }

      if (string.IsNullOrEmpty(textBoxPlcCreatorPort.Text))
      {
        MessageBox.Show("Insert connection port.", "No connection port", MessageBoxButtons.OK);
        return;
      }

      Program.newPlc = new Plc(
        textBoxPlcCreatorName.Text,
        textBoxPlcCreatorIp.Text,
        int.Parse(textBoxPlcCreatorPort.Text)
      );
      Close();
    }

    private void buttonPlcCreatorClose_Click(object sender, System.EventArgs e)
    {
      Close();
    }
  }
}