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
  
  public int CalculateBreadCost() 
  {
    int freeBread = (UserBread/2);
    int breadPaidInFull = UserBread - freeBread;
    Console.WriteLine(breadPaidInFull);
    int cost = breadPaidInFull * 5;
    return cost;
  }

  }
}

