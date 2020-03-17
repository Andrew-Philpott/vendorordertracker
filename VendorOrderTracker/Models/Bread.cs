namespace VendorOrderTracker.Models
{
  public class Bread : BakedGood
  {
    public Bread() { }
    public Bread(string name, double price) : base(name, price)
    {
      PriceForOne = 5.00;
      PriceForDeal = 2 * PriceForOne;
      NumberOfBakedGoodsForDeal = 2;
      NumberOfBakedGoodsFreeFromDeal = 1;
    }
  }
}
