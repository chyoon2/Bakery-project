using System;
using System.Linq;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our specials today are Bread: Buy 2, get 1 free. A single loaf costs $5 & Pastry: Buy 1 for $2 or 3 for $5.");
      string purchase= "";
      while(!(purchase == "NO"))
      {
        Console.WriteLine("How many loaves of Bread would you like?)");
        string stringBreadInput = Console.ReadLine();
        int breadInput = int.Parse(stringBreadInput);
        Bread newBread = new Bread(breadInput);
        newBread.AddToList();

        Console.WriteLine("How many pastries would you like?");
        string stringPastryInput = Console.ReadLine();
        int pastryInput = int.Parse(stringPastryInput);
        Pastry newPastry = new Pastry(pastryInput);
        newPastry.AddToList();

        int subtotalBread = newBread.CalculateCost();
        int subtotalPastry = newPastry.CalculateCost();
        int grandTotal = subtotalBread + subtotalPastry;
        Console.WriteLine("Your grand total is: $" + grandTotal);

        Console.WriteLine("Would you like more bread or pastry? Yes/No");
        purchase= Console.ReadLine().ToUpper();
        if (purchase == "YES"){
        } else if (!(purchase == "NO" || purchase == "YES")) {
            while (!(purchase == "NO" || purchase == "YES")) {
              
              Console.WriteLine("Please answer yes or no");
              purchase = (Console.ReadLine()).ToUpper();
          }
        }
      }
    }
  }
}