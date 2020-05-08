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
        
      }
    }
     int total = (quantity-freeLoaves)*price;
  }
