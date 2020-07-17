using System;
using System.Linq;

namespace Bakery.Models
{

  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our specials today are Bread: Buy 2, get 1 free. A single loaf costs $5 & Pastry: Buy 1 for $2 or 3 for $5.");
      
      Bread newBread = new Bread(0);
      Pastry newPastry = new Pastry(0);
      int breadTotal= 0;
      int pastryTotal=0;
      string purchase = "";

      Console.WriteLine("What would you like today? (Bread/Pastry)");
      purchase = (Console.ReadLine()).ToUpper();

      while (!(purchase == "BREAD" || purchase == "PASTRY"))
      {
        Console.WriteLine("Sorry you can only choose Bread or Pastry");
        purchase = (Console.ReadLine()).ToUpper();
      }
  
       
      while(!(purchase == "NO"))
      {
        if (purchase == "BREAD")
        {
          Console.WriteLine("How many loaves of bread would you like?");
          string stringBreadInput = Console.ReadLine();
          int breadInput = int.Parse(stringBreadInput);
          newBread.AddToList(breadInput);
          breadTotal = newBread.CalculateCost();
          Console.WriteLine("Your running total is: $" + (pastryTotal+breadTotal));
          Console.WriteLine("Would you like to add Pastries?(Yes/No)");
          purchase = (Console.ReadLine()).ToUpper();
          while (!(purchase == "YES" || purchase == "NO"))
          {
            Console.WriteLine("Please answer YES or NO");
            purchase = (Console.ReadLine()).ToUpper();
          }
          if (purchase == "YES")
          {
            purchase = "PASTRY";
          }
          else
          {
            purchase = "NO";
          }
        }

        else if (purchase == "PASTRY")
        {
          Console.WriteLine("How many pastries would you like?");
          string stringPastryInput = Console.ReadLine();
          int pastryInput = int.Parse(stringPastryInput);
          newPastry.AddToList(pastryInput);
          pastryTotal = newPastry.CalculateCost();
          Console.WriteLine("Your running total is: $" + (pastryTotal+breadTotal));
          Console.WriteLine("Would you like to add Bread?(Yes/No)");
          purchase = (Console.ReadLine()).ToUpper();
          while (!(purchase == "YES" || purchase == "NO"))
          {
            Console.WriteLine("Please answer YES or NO");
            purchase = (Console.ReadLine()).ToUpper();
          }
          if (purchase == "YES")
          {
            purchase = "BREAD";
          }
          else
          {
            purchase = "NO";
          }
        }  
      }
      int subBread = newBread.CalculateCost();
      int subPastry = newPastry.CalculateCost();
      int grandTotal = subBread + subPastry;
      Console.WriteLine("Your grand total is: $" + grandTotal);
    }
  }
}
