using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main ()
    {
      Bread newBread = new Bread(5);
      newBread.CalculateBreadCost();

    }
  }
  
}