using System;

namespace Bakery.Models
{
  public class Pastry : Bake
  {
    public int UserPastry { get; }

    public Pastry(int pastryInput)
    {
      UserPastry = pastryInput;
    }
    public int CalculatePastryCost(int UserPastry) 
    {
      int cost = ((UserPastry/3)*5)+((UserPastry % 3)*2);
      return cost;
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