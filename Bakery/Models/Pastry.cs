using System;
using System.Collections.Generic;
using System.Linq;


namespace Bakery.Models
{
  public class Pastry
  {
    public int UserPastry { get; }
    private static List <int> _queue = new List<int> {};

    public Pastry(int pastryInput)
    {
      UserPastry = pastryInput;
    }

    public List<int> AddToList(int morePastry)
    {
      _queue.Add(morePastry);
      return _queue;
    }

    public int CalculatePastryCost() 
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
// namespace Bakery.Models
// {
//   public class Pastry
//   {
//     public int UserPastry { get; }

//     public Pastry(int pastryInput)
//     {
//       UserPastry = pastryInput;
//     }
//     public int CalculateCost(int UserPastry) 
//     {
//       int cost = ((UserPastry/3)*5)+((UserPastry % 3)*2);
//       return cost;
//     }
//   }
// }