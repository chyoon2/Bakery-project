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
    
  }
}