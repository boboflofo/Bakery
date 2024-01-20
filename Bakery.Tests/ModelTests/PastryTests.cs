using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsAmount_Int()
    {
      int amount = 1;
      Pastry newPastry = new Pastry(amount);

      int result = newPastry.Amount;
      Assert.AreEqual(amount, result);
    }

    [TestMethod]

    public void GetPriceWith3_ReturnsPrice_Int()
    {
      int price = 6;
      Pastry newPastry = new Pastry(4);
      newPastry.SetPrice();
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetPriceWith7_ReturnsPrice_Int()
    {
      int price = 12;
      Pastry newPastry = new Pastry(8);
      newPastry.SetPrice();
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }
  }
}