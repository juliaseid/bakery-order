using System;
using Bakery.Items;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Carb Overload's online ordering system! How many loaves of bread would you like?");
      int quantity = int.Parse(Console.ReadLine());
      Bread breadBuy = new Bread(quantity);
      breadBuy.Order();

      

    }

  }



}