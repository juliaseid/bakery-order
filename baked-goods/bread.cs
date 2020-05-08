using System;

namespace Bakery.Items
{
  public class Bread
  {
    public int Price {get; set; }
    public int Quantity {get; set; }
  }

  public Bread(int quantity)
  {
    Price = 5;
    Quantity = quantity;
  } 
