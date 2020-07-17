using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
    Pastry.ClearAll();
    }

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
      int testPastry = 7;
      Pastry newPastry = new Pastry(testPastry);
      newPastry.AddToList(5);
      int testCost = 9;
      int result = newPastry.CalculatePastryCost();
      Assert.AreEqual(testCost, result);
    }
    [TestMethod]
    public void AddToList_ReturnsList_List()
    {
      int testEntry = 1;
      Pastry newPastry = new Pastry (testEntry);
      List<int> testList = new List<int> {1};

      List<int> result = newPastry.AddToList(1);

      CollectionAssert.AreEqual(testList, result);
    }
  }
}