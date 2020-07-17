using System.Collections.Generic;
using System;
using System.Globalization;

namespace Bakery.Models
{
  public class Bread
  {
    public int UserBread { get; }

  public Bread(int breadInput)
  {
    UserBread = breadInput;
  }
  
  public int CalculateCost() 
  {
    int freeBread = (UserBread/2);
    int breadPaidInFull = UserBread - freeBread;
    Console.WriteLine(breadPaidInFull);
    int cost = breadPaidInFull * 5;
    Console.WriteLine(cost);
    return cost;
  }

  }
}

//constructor takes a int/string
//declare a field, with autoimplemented
//method that calculates the cost and returns an integer
// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for \$2 or 3 for $5.