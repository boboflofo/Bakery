using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
     Console.WriteLine("Welcome to the Bakery!");
     Console.WriteLine("The cost for each bread item is $5, and the cost for each pastry item is $2");
     Console.WriteLine("There is a special deal available!");
     Console.WriteLine("There is a buy 2, get 1 free promotion for bread items, and a buy 3, get 1 free promotion for pastry items");
      Console.WriteLine("Please enter the number of bread items to purchase:");
      int breadItems = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Please enter the number of pastry items to purchase:");
      int pastryItems = Convert.ToInt32(Console.ReadLine());
      ProcessTotalPrice(breadItems,pastryItems);
    }

    static void ProcessTotalPrice(int breadAmount, int pastryAmount) 
    {
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetPrice();
      int total = newBread.Price + newPastry.Price;
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your total cost is: $" + total + ".");
      Console.WriteLine("-----------------------------------------");
    }
  }
}