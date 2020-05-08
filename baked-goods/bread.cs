using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Quantity {get; set; }
  }

  public Bread(int quantity)
  {
    Quantity = quantity;
  }

  private static int price = 5;
  private int freeLoaves = quantity/3;

  public int Order()
  {
    if (quantity % 3 == 0)
    {
      Console.WriteLine("You are getting " + freeLoaves + " free!");
    }
    else if (quantity % 3 =! 0)
    {
      int over = (quantity % 3);
      if (over >= 2) 
      {
        Console.WriteLine("You could get " + freeLoaves + " free loaves of bread.  How many would you like?");
        quantity += Console.ReadLine();
      }
      else if (over < 2)
      {
       Console.WriteLine("You are getting " + freeLoaves + " free! If you add one more loaf, you'll get another free.  Would you like more?");
       if (Console.ReadLine()=="yes") 
       {
         Console.WriteLine("Great! We'll add 2 loaves to your order, but you'll only be charged for one!");
         quantity ++;
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
     int total = (quantity-freeLoaves)*price;
     return total
  }
