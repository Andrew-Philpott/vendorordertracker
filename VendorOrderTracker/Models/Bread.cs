namespace VendorOrderTracker.Models
{
  public abstract class Bread : BakedGood
  {
    public Bread() { }
    public Bread(string name) : base(name)
    {
      PriceForOne = 5.00;
      PriceForDeal = 2 * PriceForOne;
      NumberOfBakedGoodsForDeal = 2;
      NumberOfBakedGoodsFreeFromDeal = 1;
    }
  }
}
