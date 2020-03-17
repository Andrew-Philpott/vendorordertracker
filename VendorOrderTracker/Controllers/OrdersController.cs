using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    private readonly TrackerContext _db;

    public OrdersController(TrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Order> model = _db.Orders.ToList();
      return View(model);
    }

    // [HttpGet("/orders")]
    // public ActionResult Index()
    // {
    //   List<Order> orders = Order.GetAllOrders();
    //   return View(orders);
    // }

    // [HttpGet("/vendors/{vendorId}/orders/new")]
    // public ActionResult New(int vendorId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   return View(vendor);
    // }

    // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    // public ActionResult Show(int vendorId, int orderId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   Order order = vendor.GetOrder(orderId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("vendor", vendor);
    //   model.Add("order", order);
    //   return View(model);
    // }

    // [HttpGet("/orders/{orderId}/delete")]
    // public ActionResult Delete(int orderId)
    // {
    //   Order order = Order.Find(orderId);
    //   Vendor.Find(order.VendorId).DeleteOrder(orderId);
    //   Order.Delete(orderId);
    //   return RedirectToAction("Index");
    // }
  }
}