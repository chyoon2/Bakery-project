using System;
// using Bread;
// using Pastry.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main ()
    {
      Bread newBread = new Bread(5);
      newBread.CalculateCost();
    }
  }
  
}