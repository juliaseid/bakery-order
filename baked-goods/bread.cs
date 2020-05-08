using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Quantity {get; set;}

    public Bread(int quantity)
    {
      Quantity = quantity;
      freeLoaves = quantity/3;
    }

    private static int price = 5;
    private int freeLoaves;

    public void AddLoaves(int loaves)
    {
      Quantity = Quantity + loaves;
      freeLoaves = Quantity/3;
    }

    public int Order()
    {
      if (Quantity == 0)
      {
        Console.WriteLine("Ok, no bread! On to the pastries!");
      }
      else if (Quantity % 3 == 0)
      {
        Console.WriteLine("You are getting " + freeLoaves + " loaves free!");
      }
      else
      {
        int over = (Quantity % 3);
        if (over >= 2) 
        {
          Console.WriteLine("You are getting " + freeLoaves + " loaf for free. You could get one more loaf free, too.  Would you like one more?");
          if (Console.ReadLine()=="yes")
          {
            Console.WriteLine("You got it! One more loaf added!");
            AddLoaves(1);
          }
          else if (Console.ReadLine()=="no")
          {
            Console.WriteLine("No problem.  We'll stick with your original order.");
          }
        }
        else
        {
          Console.WriteLine("If you add one more loaf, you'll get another free.  Would you like more?");
          if (Console.ReadLine()=="yes") 
          {
            Console.WriteLine("Great! We'll add 2 loaves to your order, but you'll only be charged for one!");
            AddLoaves(2);
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
              AddLoaves(2);
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
