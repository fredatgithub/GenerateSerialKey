using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenerateSerialKey;

namespace UnitTestGenerateSerialKey
{
  [TestClass]
  public class UnitTestGenerateRandomString
  {
    [TestMethod]
    public void TestMethod_1()
    {
      const int source = 1;
      const int expected = 1;
      string result = FormMain.GenerateRandomString(source);
      Assert.AreEqual(result.Length, expected);
    }
  }
}