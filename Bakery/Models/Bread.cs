using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public class Bread
  {
    public int UserBread { get; }
    private static List <int> _queue = new List<int> {};
    
    public Bread(int breadInput)
    {
      UserBread = breadInput;
    }

    public List<int> AddToList(int moreBread)
    {
      _queue.Add(moreBread);
      return _queue;
    }
    
    public int CalculateBreadCost( ) 
    {
      int cost = (UserBread - (UserBread/2)) * 5;
      return cost;
    }
     public static void ClearAll()
    {
      // _queue.Clear();
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