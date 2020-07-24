using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Pastry : Cart
  {
    private static List <int> _queue = new List<int> {};
    
    public Pastry(int pastryInput)
    {
      Quantity = pastryInput;
    }

    public List<int> AddToList()
    {
      _queue.Add(Quantity);
      return _queue;
    }

    public override int CalculateCost() 
    {
      int amt = _queue.AsQueryable().Sum();
      int cost = ((amt/3)*5)+((amt % 3)*2);
      return cost;
    }

    public static void ClearAll()
    {
      _queue.Clear();
    }
  }
}