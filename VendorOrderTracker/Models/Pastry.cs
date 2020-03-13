namespace VendorOrderTracker.Models
{
  public abstract class Pastry : BakedGood
  {
    public Pastry() { }
    public Pastry(string name) : base(name)
    {
      PriceForOne = 2.00;
      PriceForDeal = 2.5 * PriceForOne;
      NumberOfBakedGoodsForDeal = 3;
      NumberOfBakedGoodsFreeFromDeal = 0;
    }
  }
}