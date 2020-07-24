using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests: IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

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
      int result = newBread.Quantity;
      Assert.AreEqual(testBread, result);
    }
    [TestMethod]
    public void CalculateCost_ReturnsCost_Int()
    {
      int testBread = 7;
      Bread newBread = new Bread(testBread);
      newBread.AddToList();
      int testCost = 20;
      int result = newBread.CalculateCost();
      Assert.AreEqual(testCost, result);
    }
    [TestMethod]
    public void AddToList_ReturnsList_List()
    {
      int testEntry = 1;
      Bread newBread = new Bread (testEntry);
      List<int> testList = new List<int> {1};
      List<int> result = newBread.AddToList();
      CollectionAssert.AreEqual(testList, result);
    }
  }
}