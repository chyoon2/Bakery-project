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
      int result = newBread.UserBread;
      Assert.AreEqual(testBread, result);
    }
    [TestMethod]
    public void CalculateBreadCost_ReturnsCost_Int()
    {
       int testBread = 7;
      Bread newBread = new Bread(testBread);
      newBread.AddToList(5);
      int testCost = 9;
      int result = newBread.CalculateBreadCost();
      Assert.AreEqual(testCost, result);
    }
    [TestMethod]
    public void AddToList_ReturnsList_List()
    {
      int testEntry = 1;
      Bread newBread = new Bread (testEntry);
      List<int> testList = new List<int> {1};
      List<int> result = newBread.AddToList(1);
      CollectionAssert.AreEqual(testList, result);
    }
  }
}