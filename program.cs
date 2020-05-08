using System;
using Bakery.Items;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Carb Overload's online ordering system! How many loaves of bread would you like?  Every 3rd loaf is free!");
      int breadQuantity = int.Parse(Console.ReadLine());
      Bread breadBuy = new Bread(breadQuantity);
      int breadTotal = breadBuy.Order();
      Console.WriteLine("We have a wide range of pastries to choose from, all $2 each or 3 for $5.  How many would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());
      Pastry pastryBuy = new Pastry(pastryQuantity);
      int pastryTotal = pastryBuy.Order();
      int orderTotal = breadTotal ;
      Console.WriteLine("For " + breadBuy.Quantity + " loaves of bread and " + pastryBuy.Quantity + " pastries, your total is $" + orderTotal + ". Enjoy, and come back soon!");

    }

  }



}