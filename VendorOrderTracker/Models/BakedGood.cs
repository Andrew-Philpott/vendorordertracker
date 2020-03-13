namespace VendorOrderTracker.Models
{
  public abstract class BakedGood
  {
    public string Name { get; set; }
    public int BreadCount { get; set; }
    public double PriceForOne { get; protected set; } = 0;
    public double PriceForDeal { get; protected set; } = 0;
    public int NumberOfBakedGoodsForDeal { get; protected set; } = 0;
    public int NumberOfBakedGoodsFreeFromDeal { get; protected set; } = 0;

    public BakedGood() { }
    public BakedGood(string name)
    {
      Name = name;
    }

    public double CalculateCostForBakedGoods(int numberOfBakedGoods)
    {
      int numberOfBakedGoodsDeals = 0;
      int numberOfRegularPriceBakeGoods = 0;
      if (numberOfBakedGoods % ((NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal)) == 0)
      {
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }
      else
      {
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
        numberOfRegularPriceBakeGoods = numberOfBakedGoods % (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }

      double costOfBakedGoodsDeals = numberOfBakedGoodsDeals * PriceForDeal;
      double costOfRegularPricedBakedGood = numberOfRegularPriceBakeGoods * PriceForOne;
      return costOfBakedGoodsDeals + costOfRegularPricedBakedGood;
    }
  }
}
