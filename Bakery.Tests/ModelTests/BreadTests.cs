using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadInput_ReturnsBreadInput_Int()
    {
      int testBread = 5;
      Bread newBread = new Bread(testBread);
      int result = newBread.UserBread;
      Assert.AreEqual(testBread, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_Int()
    {
      int testBread = 5;
      Bread newBread = new Bread(testBread);
      int testCost = 15;
      int result = newBread.CalculateCost();

      Assert.AreEqual(testCost, result);
    }
  }
}