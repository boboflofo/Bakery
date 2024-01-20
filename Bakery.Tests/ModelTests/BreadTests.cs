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

    [TestMethod]
    public void GetPriceWith3_ReturnsPrice_Int()
    {
      int price = 10;
      Bread newBread = new Bread(3);
      newBread.SetPrice();
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetPriceWith7_ReturnsPrice_Int()
    {
      int price = 25;
      Bread newBread = new Bread(7);
      newBread.SetPrice();
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }


  }
}