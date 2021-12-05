using PlcDataCollector.PlcConnection;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlcDataCollector
{
  public partial class FormVariableCreator : Form
  {
    public FormVariableCreator()
    {
      InitializeComponent();
      List<string> items = new Datatypes().GetDatatypes();
      foreach (string item in items)
      {
        comboBoxVariableCreatorType.Items.Add(item);
      }
    }

    private void buttonVariableCreatorOk_Click(object sender, System.EventArgs e)
    {
      if (string.IsNullOrEmpty(comboBoxVariableCreatorType.Text))
      {
        return;
      }

      if (string.IsNullOrEmpty(textBoxVariableCreatorName.Text))
      {
        return;
      }

      Program.newVariable = new Variable(comboBoxVariableCreatorType.Text, textBoxVariableCreatorName.Text);
      Close();
    }

    private void buttonVariableCreatorClose_Click(object sender, System.EventArgs e)
    {
      Close();
    }
  }
}