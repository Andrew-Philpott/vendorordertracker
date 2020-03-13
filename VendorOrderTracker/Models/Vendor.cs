using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<BakedGood> Breads = new List<BakedGood>() { new Bagel(), new Baguette(), new Challah() };
    private static List<BakedGood> Pastries = new List<BakedGood>() { new BearClaw(), new CupCake(), new Danish() };
    private static List<Vendor> _vendors = new List<Vendor>();
    // private static Dictionary<int, string> _breads = new Dictionary<int, string> {
    //   {1, "bagel"}, {2, "baguette"}, {3, "challah"}};
    // private static Dictionary<int, string> _pastries = new Dictionary<int, string> {
    //   {1, "bearclaw"}, {2, "cupcake"}, {3, "danish"}};
    private static int AssignId { get; set; }

    public int Id { get; }
    private List<Order> _orders = new List<Order>();
    public string Name { get; set; }
    public string Description { get; set; }

    public List<BakedGood> BakedGoods = new List<BakedGood>();
    public Vendor(string name, string description)
    {
      Id = AssignId++;
      Name = name;
      Description = description;
      switch (description)
      {
        case "bread":
          BakedGoods = Breads;
          break;
        case "pastry":
          BakedGoods = Pastries;
          break;
        case "both":
          BakedGoods.Add(new Bagel());
          BakedGoods.Add(new Baguette());
          BakedGoods.Add(new Challah());
          BakedGoods.Add(new CupCake());
          BakedGoods.Add(new Danish());
          BakedGoods.Add(new BearClaw());
          break;
        default:
          break;
      }
      // string[] bakedGoodsItems = description.Split(",");



      // foreach (string bakedGood in bakedGoodsItems)
      // {
      //   switch (bakedGood)
      //   {
      //     case "bagel":
      //       BakedGoods.Add(new Bagel());
      //       break;
      //     case "baguette":
      //       BakedGoods.Add(new Baguette());
      //       break;
      //     case "bearclaw":
      //       BakedGoods.Add(new BearClaw());
      //       break;
      //     case "cupcake":
      //       BakedGoods.Add(new CupCake());
      //       break;
      //     case "challah":
      //       BakedGoods.Add(new Challah());
      //       break;
      //     case "danish":
      //       BakedGoods.Add(new Danish());
      //       break;
      //   }
      //   if (bakedGood == "danish")
      //   {
      //     BakedGoods.Add(new Danish());
      //   }
      // }
    }

    public static string GenerateRandomBread()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, _breads.Count - 1);
      return _breads[randomNumber];
    }
    public static string GenerateRandomPastry()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, _breads.Count - 1);
      return _pastries[randomNumber];
    }


    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }
    public List<Order> GetOrders()
    {
      return _orders;
    }
    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }
  }
}