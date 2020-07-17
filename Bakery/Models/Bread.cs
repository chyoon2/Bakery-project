using System;

namespace Bakery.Models
{
  public class Bread: IDataAccess
  {
    // public int UserBread { get; }

    // public Bread(int breadInput)
    // {
    //   UserBread = breadInput;
    // }
    
    public int CalculateCost(int userBread ) 
    {
      int cost = (userBread - (userBread/2)) * 5;
      return cost;
    }

  }
}