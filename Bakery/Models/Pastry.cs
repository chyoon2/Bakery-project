using System.Collections.Generic;
using System;
using System.Globalization;

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
}// Pastry: Buy 1 for \$2 or 3 for $5.