using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor>();
    private List<Order> _orders = new List<Order>();
    public string Name { get; set; }
    public string Description { get; set; }

    public List<BakedGood> _bakedGoods = new List<BakedGood>();
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }
  }
}