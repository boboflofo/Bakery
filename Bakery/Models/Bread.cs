using System;
namespace Bakery.Models
{
  public class Bread
  {
    public int Amount{ get; set;}
    public int Price{get; set;}
    public Bread(int amount)
    {
      Amount = amount;
    }

    public void SetPrice()
    {
      if (Amount / 3 >= 1)
      {
        Price = (5 * Amount) - (5 * (int)Math.Floor((decimal)Amount / 3));
      }
      else
      {
        Price = 5* Amount;
      }
    }
  }
}