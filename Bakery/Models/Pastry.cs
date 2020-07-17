using System;

namespace Bakery.Models
{
  public class Pastry: IDataAccess
  {
    // public int UserPastry { get; }

    // public Pastry(int pastryInput)
    // {
    //   UserPastry = pastryInput;
    // }
    public int CalculateCost(int userPastry) 
    {
      int cost = ((userPastry/3)*5)+((userPastry % 3)*2);
      return cost;
    }
  }
}