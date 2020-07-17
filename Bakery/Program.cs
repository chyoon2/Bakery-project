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
      int breadCost = newBread.CalculateBreadCost(breadInput);

      Pastry newPastry = new Pastry(pastryInput);
      int pastryCost = newPastry.CalculatePastryCost(pastryInput);
      string more = "Y";
      while( more == "Y")
      {
        Console.WriteLine("How many more loaves of bread would you like?");
        string you = Console.ReadLine();
        Console.WriteLine("Do you want to add more bread?(Y/N)");
        more = Console.ReadLine();
      }
     

      int total = breadCost + pastryCost;
      Console.WriteLine("Your total is $" + total);
    

    // List<IDataAccess> databases = new List<IDataAccess>() {
    //   new Pastry(),
    //   new Bread()
    // };
    // foreach(int x in databases)
    // {
    //   Console.WriteLine(x.CalculateBreadCost(2));
    //   Console.WriteLine(x.CalculatePastryCost(2));
    // }
    }
  }
}