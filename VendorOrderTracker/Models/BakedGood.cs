namespace VendorOrderTracker.Models
{
  public class BakedGood
  {
    // public int BakedGoodId { get; set; }
    // public string Name { get; set; }
    // public double Price { get; set; }

    public int BakedGoodId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public int VendorId { get; set; }
    public virtual Vendor Vendor { get; set; }

    // public int BreadCount { get; set; }
    // public double Price { get; protected set; } = 0;
    // public double PriceForOne { get; protected set; } = 0;
    // public double PriceForDeal { get; protected set; } = 0;
    // public int NumberOfBakedGoodsForDeal { get; protected set; } = 0;
    // public int NumberOfBakedGoodsFreeFromDeal { get; protected set; } = 0;

    // public BakedGood() { }
    // public BakedGood(string name, double price)
    // {
    //   Price = price;
    //   Name = name;
    // }

    // public double CalculateCostForBakedGoods(int numberOfBakedGoods)
    // {
    //   int numberOfBakedGoodsDeals = 0;
    //   int numberOfRegularPriceBakeGoods = 0;
    //   if (numberOfBakedGoods % ((NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal)) == 0)
    //   {
    //     numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
    //   }
    //   else
    //   {
    //     numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
    //     numberOfRegularPriceBakeGoods = numberOfBakedGoods % (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
    //   }

    //   double costOfBakedGoodsDeals = numberOfBakedGoodsDeals * PriceForDeal;
    //   double costOfRegularPricedBakedGood = numberOfRegularPriceBakeGoods * PriceForOne;
    //   return costOfBakedGoodsDeals + costOfRegularPricedBakedGood;
    // }
  }
}
