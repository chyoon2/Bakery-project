using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{
  public abstract class Cart
  {
    public int Quantity { get; set; }

    public abstract int CalculateCost();
  }
}