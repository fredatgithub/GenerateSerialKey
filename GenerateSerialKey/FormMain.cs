using System;
using System.Drawing;
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
      for (int i = 0; i < 6; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }

      result += "-";
      for (int i = 0; i < 2; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }

      result += AddZero(DateTime.Now.Day);
      for (int i = 0; i < 2; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }

      result += "-";
      //AAAAA-AADDAA-AMMAAA-AAYYYYAA
      result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      result += AddZero(DateTime.Now.Month);
      for (int i = 0; i < 3; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }

      result += "-";
      for (int i = 0; i < 2; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }

      result += DateTime.Now.Year;
      for (int i = 0; i < 2; i++)
      {
        result += GenerateRandomNumberUsingCrypto(0, 9).ToString();
      }
      return result;
    }

    private static string AddZero(int number)
    {
      return number < 10 ? $"0{number}" : number.ToString();
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

    private void ButtonVerifyKey_Click(object sender, EventArgs e)
    {
      if (textBoxKey.Text.Trim() == string.Empty)
      {
        return;
      }

      //AAAAA-AADDAA-AMMAAA-AAYYYYAA
      //1234567890123456789012345678
      //         10        20
      string theKey = textBoxKey.Text;
      bool keyIsValid = true;
      int extractedDay;
      if (!int.TryParse(theKey.Substring(9, 2), out extractedDay))
      {
        keyIsValid = false;
      }

      int extractedMonth;
      if (!int.TryParse(theKey.Substring(15, 2), out extractedMonth))
      {
        keyIsValid = false;
      }

      int extractedYear;
      if (!int.TryParse(theKey.Substring(23, 4), out extractedYear))
      {
        keyIsValid = false;
      }

      if (theKey.Length != 29)
      {
        keyIsValid = false;
      }

      textBoxCheckKeyValidity.Text = $"Key is {Negate(keyIsValid)}valid";
      textBoxCheckKeyValidity.BackColor = ColorBackground(keyIsValid);

      DateTime extractedDate = new DateTime(extractedYear, extractedMonth, extractedDay);

      textBoxKeyGenerationDate.Text = $"Key was generated on {extractedDate.ToShortDateString()}";
      textBoxKeyExpiration.Text = $"Key will expired on {extractedDate.AddDays(30).ToShortDateString()}";
    }

    private static Color ColorBackground(bool validOrInvalid)
    {
      return validOrInvalid ? Color.Green : Color.Red;
    }

    private static string Negate(bool trueOrFalse)
    {
      return trueOrFalse ? string.Empty : "not ";
    }
  }
}