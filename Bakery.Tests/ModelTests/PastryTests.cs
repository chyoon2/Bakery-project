using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryInput_ReturnsPastryInput_Int()
    {
      int testPastry = 5;
      Pastry newPastry = new Pastry(testPastry);
      int result = newPastry.UserPastry;
      Assert.AreEqual(testPastry, result);
    }
     [TestMethod]
    public void CalculatePastryCost_ReturnsCost_Int()
    {
      int testPastry = 5;
      Pastry newPastry = new Pastry(testPastry);
      int testCost = 15;
      int result = newPastry.CalculatePastryCost();

      Assert.AreEqual(testCost, result);
    }
  }
}