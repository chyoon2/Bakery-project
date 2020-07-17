using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class TranslateTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadNumber_ReturnsBreadNumber_Int()
    {
      int testBread = 5;
      Bread newBread = new Bread(testBread);
      int result = newBread.UserBread;
      Assert.AreEqual(testBread, result);
    }
    public void CalculateCost_ReturnsCost_Int()
    {
      int testBread = 5;
      Bread newBread = new Bread(testBread);
      int testCost = 10;
      int result = newBread.CalculateCost;
      Assert.AreEqual(testCost, result);
    }

  }
}