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
      int breadTotal = newBread.CalculateCost();
      int pastryTotal = newPastry.CalculateCost();

      string purchase = "";
      Console.WriteLine("What would you like today? (Bread/Pastry)");
      purchase = (Console.ReadLine()).ToUpper();

      while (!(purchase == "BREAD" || purchase == "PASTRY"))
      {
        Console.WriteLine("Sorry you can only choose Bread or Pastry");
        purchase = (Console.ReadLine()).ToUpper();
      }
  
      string answer = ""; 
      while(!(answer == "no"))
      {
        if (purchase == "BREAD")
        {
          Console.WriteLine("How many loaves of bread would you like?");
          string stringBreadInput = Console.ReadLine();
          int breadInput = int.Parse(stringBreadInput);
          newBread.AddToList(breadInput);
          breadTotal = newBread.CalculateCost();
          Console.WriteLine("Your running total is: $" + (pastryTotal+breadTotal));
          Console.WriteLine("Would you like to add Pastries?(Y/N)");
          answer = (Console.ReadLine()).ToUpper();

          if (answer == "Y")
          {
            purchase = "PASTRY";
          }
          else
          {
            answer = "no";
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
          Console.WriteLine("Do you add more bread?(Y/N)");
          answer = (Console.ReadLine()).ToUpper();
          if (answer == "Y")
          {
            purchase = "BREAD";
          }
          else
          {
            answer = "no";
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

    
