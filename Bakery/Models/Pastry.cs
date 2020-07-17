using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int UserPastry { get; }

    public Pastry(int pastryInput)
    {
      UserPastry = pastryInput;
    }
    public int CalculatePastryCost() 
  {
    int fiveDollarPastry = (UserPastry/3);
    int twoDollarPastry = UserPastry % 3;
    int cost = (twoDollarPastry * 2) + (fiveDollarPastry * 5);
    return cost;
  }
  }
}