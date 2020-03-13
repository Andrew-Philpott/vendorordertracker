using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Bread> Breads = new List<Bread>() { new Bagel(), new Baguette(), new Challah() };
    private static List<Pastry> Pastries = new List<Pastry>() { new BearClaw(), new CupCake(), new Danish() };
    private static List<Vendor> _vendors = new List<Vendor>();
    private static int AssignId { get; set; }

    public int Id { get; }
    private List<Order> _orders = new List<Order>();
    public string Name { get; set; }
    public string Description { get; set; }

    public int PriceForGood { get; set; }
    public BakedGood BakedGood;
    public Vendor(string name, string description)
    {
      Random random = new Random();
      PriceForGood = random.Next(3, 5);
      Id = AssignId++;
      Name = name;
      Description = description;
      switch (description)
      {
        case "bread":
          BakedGood = GenerateRandomBread();
          break;
        case "pastry":
          BakedGood = GenerateRandomPastry();
          break;
        default:
          break;
      }
      _vendors.Add(this);
    }

    public Bread GenerateRandomBread()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, Breads.Count - 1);
      return Breads[randomNumber];
    }
    public Pastry GenerateRandomPastry()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, Pastries.Count - 1);
      return Pastries[randomNumber];
    }

    public Order GetOrder(int id)
    {
      return _orders.Find(x => x.Id == id);
    }
    public static List<Vendor> GetAllVendors()
    {
      return _vendors;
    }
    public static Vendor Find(int id)
    {
      return _vendors.Find(x => x.Id == id);
    }
    public List<Order> GetOrders()
    {
      return _orders;
    }
    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }

    public void DeleteOrder(int id)
    {
      _orders.Remove(_orders.Find(x => x.Id == id));
    }
  }
}