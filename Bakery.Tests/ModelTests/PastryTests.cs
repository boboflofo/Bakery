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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]

    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Pastry newPastry = new Pastry(1);

      int result = newPastry.Price;
      Assert.AreEqual(price,result);
    }
  }
}