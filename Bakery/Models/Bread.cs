using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int UserBread { get; }

    public Bread(int breadInput)
    {
      UserBread = breadInput;
    }
    
    public int CalculateBreadCost(int UserBread ) 
    {
      int cost = (UserBread - (UserBread/2)) * 5;
      return cost;
    }

  }
}

// namespace Bakery.Models
// {
//   public class Bread
//   {
//     public int UserBread { get; }

//     public Bread(int breadInput)
//     {
//       UserBread = breadInput;
//     }
    
//     public int CalculateCost(int UserBread ) 
//     {
//       int cost = (UserBread - (UserBread/2)) * 5;
//       return cost;
//     }

//   }
// }