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
    public DateTime Date { get; set; }
    public Order(string title, string description, double price, DateTime date)
    {
      Id = AssignId++;
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
    }

    public static List<Order> GetAllOrders()
    {
      return _orders;
    }
  }
}