using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      int amount = 1;
      Bread newBread = new Bread(amount);

      int result = newBread.Amount;
      Assert.AreEqual(amount, result);
    }
  }
}