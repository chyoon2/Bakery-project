using System;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our specials today are Bread: Buy 2, get 1 free. A single loaf costs $5 & Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadInput = Console.ReadLine();
      int breadInput = int.Parse(stringBreadInput);

      Console.WriteLine("How many pastries would you like?");
      string stringPastryInput = Console.ReadLine();
      int pastryInput = int.Parse(stringPastryInput);

      
      Bread newBread = new Bread(breadInput);
      int breadCost = newBread.CalculateBreadCost();

      Pastry newPastry = new Pastry(pastryInput);
      int pastryCost = newPastry.CalculatePastryCost();
      int total = breadCost + pastryCost;

      Console.WriteLine("Your total is $" + total);
    }
  }
}