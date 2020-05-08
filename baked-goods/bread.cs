using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Quantity {get; set; }
  

    public Bread(int quantity)
    {
      Quantity = quantity;
      freeLoaves = quantity/3;
    }

    private static int price = 5;
    private int freeLoaves;

    public int Order()
    {
      if (Quantity == 0)
      {
        Console.WriteLine("Ok, no bread! On to the pastries!");
      }
      else if (Quantity % 3 == 0)
      {
        Console.WriteLine("You are getting " + freeLoaves + " free!");
      }
      else if (Quantity % 3 != 0)
      {
        int over = (Quantity % 3);
        if (over >= 2) 
        {
          Console.WriteLine("You could get " + freeLoaves + " free loaves of bread.  How many would you like?");
          Quantity += int.Parse(Console.ReadLine());
        }
        else if (over < 2)
        {
        Console.WriteLine("If you add one more loaf, you'll get another free.  Would you like more?");
        if (Console.ReadLine()=="yes") 
        {
          Console.WriteLine("Great! We'll add 2 loaves to your order, but you'll only be charged for one!");
          Quantity ++;
        }
        else if (Console.ReadLine()=="no")
        {
          Console.WriteLine("No problem!");
        } 
        else 
        {
          Console.WriteLine("Sorry, we didn't understand!  Would you like to pay for one more loaf and get another free?  Please enter 'yes' or 'no'.");
          if (Console.ReadLine()=="yes")
          {
            Console.WriteLine("Great!  We'll add 2 loaves to your order, but you'll only be charged for one!");
          }
          else
          {
            Console.WriteLine("OK, we'll keep your order as is.");
          }
        }
        }
      }
      int total = (Quantity-freeLoaves)*price;
      return total;
    }
  }
}
