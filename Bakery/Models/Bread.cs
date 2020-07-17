using System;

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

      int cost = (UserBread - (UserBread/2)) * 5;
      return cost;
    }

  }
}