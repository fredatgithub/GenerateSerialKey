using System;
using System.Windows.Forms;

namespace GenerateSerialKey
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
      textBoxKey.Text = CreateNewKey();
    }

    private static string CreateNewKey()
    {
      string result = string.Empty;
      
      //AAAAA-AADDAA-AMMAAA-AAYYYYAA
      return result;
    }

    public static string GenerateRandomString(int numberOfChar = 1)
    {
      var rnd = new Random();
      string result = string.Empty;
      for (int i = 0; i < numberOfChar; i++)
      {
        result += rnd.Next();
      }
      return result;
    }
  }
}
