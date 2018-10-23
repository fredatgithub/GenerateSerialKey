using System;
using System.Security.Cryptography;
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

    public static int GenerateRandomNumberUsingCrypto(int min, int max)
    {
      if (max >= 255)
      {
        return 0;
      }
      int result;
      var crypto = new RNGCryptoServiceProvider();
      var randomNumber = new byte[1];
      do
      {
        crypto.GetBytes(randomNumber);
        result = randomNumber[0];
      } while (result <= min || result >= max);

      return result;
    }

  }
}
