using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor>();
    private static int AssignId { get; set; }

    public int Id { get; }
    private List<Order> _orders = new List<Order>();
    public string Name { get; set; }
    public string Description { get; set; }

    public List<BakedGood> _bakedGoods = new List<BakedGood>();
    public Vendor(string name, string description)
    {
      Id = AssignId++;
      Name = name;
      Description = description;
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