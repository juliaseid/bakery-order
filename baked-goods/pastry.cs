using System;

namespace Bakery.Items
{
  public class Pastry
  {
    public int Quantity {get; set; }
  
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    private static int price = 2;

    public int Order ()
    {
      int total;
      if (Quantity == 0)
      {
        Console.WriteLine("No problem! You'll enjoy that bread, and you can always put jam on it if you wish you'd gotten pastries!");
        total = 0;
        return total;
      }
      else if (Quantity % 3 == 0)
      {
        total = (Quantity * price) - (Quantity/3);
        return total;
      }
      else
      {
        int over = Quantity % 3;
        if (over >= 2)
        {
          Console.WriteLine("Your next pastry is only $1! Would you like one more?");
          if (Console.ReadLine()=="yes")
          {
            Console.WriteLine("Great! We'll add another pastry!");
            Quantity ++;
            total = (Quantity * price) - (Quantity/3);
            return total;   
          }
          else if (Console.ReadLine()=="no")
          {
            Console.WriteLine("Ok, no problem! We'll keep your order as is.");
            total = (Quantity * price) - ((Quantity - over)/3);
            return total;
          }
        }
        else
        {
          total = (Quantity * price) - ((Quantity - over)/3);
          return total;
        }
      }
    }
  }
}