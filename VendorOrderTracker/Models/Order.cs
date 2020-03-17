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
    public double Price { get; set; }
    public string Date { get; set; }
    public int VendorId { get; }
    public Vendor Vendor;

    List<BakedGood> bakedGoods = new List<BakedGood>();
    public Order(int vendorId, string title, string description, int[] bakedGoods)
    {
      VendorId = VendorId;
      Date = DateTime.Now.ToString("dd.MM.yyy");
      Id = AssignId++;
      Title = title;
      Description = description;
      Vendor = Vendor.Find(vendorId);
      Price = CalculatePrice(bakedGoods, Vendor);
      _orders.Add(this);
    }

    public double CalculatePrice(int[] counts, Vendor vendor)
    {

      double price = 0;
      for (int i = 0; i < vendor.BakedGoods.Count; i++)
      {
        price += (vendor.BakedGoods[i].Price * counts[i]);
      }
      return price;
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