using System;
using System.Collections.Generic;


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

    public int CalculatePastryCost(int UserPastry) 
    {
      int cost = ((UserPastry/3)*5)+((UserPastry % 3)*2);
      return cost;
    }
    public List<int> AddToList(int morePastry)
    {
      _queue.Add(morePastry);
      return _queue;
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