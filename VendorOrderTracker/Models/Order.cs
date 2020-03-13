using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order>();
    private static int AssignId { get; set; }

    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; } = 0;
    public string Date { get; set; }
    public int VendorId { get; }

    // Dictionary<string, string> bakedGoods = new Dictionary<string, string>();
    List<BakedGood> bakedGoods = new List<BakedGood>();
    public Order(int vendorId, string title, string description, int BakedGood)
    {
      VendorId = VendorId;
      Date = DateTime.Now.ToString("dd.MM.yyy");
      Id = AssignId++;
      Title = title;
      Description = description;
      Vendor vendor = Vendor.Find(vendorId);
      Price = (vendor.PriceForGood * BakedGood);
    }
    public static List<Order> GetAllOrders()
    {
      return _orders;
    }
    public static Order Find(int id)
    {
      return _orders.Find(x => x.Id == id);
    }
    public static void Delete(int id)
    {
      _orders.Remove(_orders.Find(x => x.Id == id));
    }
  }
}