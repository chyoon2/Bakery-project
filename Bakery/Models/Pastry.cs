using System;

namespace Bakery.Models
{
  public class Pastry: IDataAccess
  {
    public int UserPastry { get; }

    public Pastry(int pastryInput)
    {
      UserPastry = pastryInput;
    }
    public int CalculatePastryCost() 
    {
      int cost = ((UserPastry/3)*5)+((UserPastry % 3)*2);
      return cost;
    }
  }
}