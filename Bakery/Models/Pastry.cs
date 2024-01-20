using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount{ get; set;}
    public int Price{get; set;}
    public Pastry(int amount)
    {
      Amount = amount;
    }

    public void SetPrice()
    {
      if (Amount / 4 >= 1)
      {
        Price = (2 * Amount) - (2 * (int)Math.Floor((decimal)Amount / 3));
      }
      else
      {
        Price = 2* Amount;
      }
    }
  }
}