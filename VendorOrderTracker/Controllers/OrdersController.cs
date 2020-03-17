using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;


namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> orders = Order.GetAllOrders();
      return View(orders);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = vendor.GetOrder(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }

    [HttpGet("/orders/{orderId}/delete")]
    public ActionResult Delete(int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor.Find(order.VendorId).DeleteOrder(orderId);
      Order.Delete(orderId);
      return RedirectToAction("Index");
    }
  }
}