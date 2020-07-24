using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread : Cart
  {
    private static List <int> _queue = new List<int> {};

    public Bread(int breadInput)
    {
      Quantity = breadInput;
    }
    public List<int> AddToList()
    {
      _queue.Add(Quantity);
      return _queue;
    }
    public override int CalculateCost() 
    {
      int amt = _queue.AsQueryable().Sum();
      int cost = (amt - (amt/2)) * 5;
      return cost;
    }
    public static void ClearAll()
    {
      _queue.Clear();
    }
  }
}
