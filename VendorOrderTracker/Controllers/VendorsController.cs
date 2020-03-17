using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    private readonly TrackerContext _db;

    public VendorsController(TrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Vendor> model = _db.Vendors.ToList();
      return View(model);
    }
    // [HttpGet("/vendors")]
    // public ActionResult Index()
    // {
    //   List<Vendor> vendors = Vendor.GetAllVendors();
    //   return View(vendors);
    // }

    // [HttpGet("/vendors/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    // [HttpPost("/vendors")]
    // public ActionResult Create(string name, string type, string description)
    // {
    //   Vendor vendor = new Vendor(name, type, description);
    //   return RedirectToAction("Index", "home");
    // }

    // [HttpGet("/vendors/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Vendor vendor = Vendor.Find(id);
    //   return View(vendor);
    // }

    // // [HttpPost("/vendors/{vendorId}/orders")]
    // // public ActionResult Create(int vendorId, string title, string description, int[] bakedGoods)
    // // {
    // //   // int[] bakedGoodsCounts = new int[] { bakedGoods };
    // //   Order order = new Order(vendorId, title, description, bakedGoods);
    // //   Vendor vendor = Vendor.Find(vendorId);
    // //   vendor.AddOrder(order);
    // //   return RedirectToAction("Show");
    // // }

    // [HttpPost("/vendors/{vendorId}/orders")]
    // public ActionResult Create(int vendorId, string title, string description, string bakedGood0)
    // {
    //   int value = int.Parse(bakedGood0);
    //   int[] bakedGoodsCounts = new int[] { value };
    //   Order order = new Order(vendorId, title, description, bakedGoodsCounts);
    //   Vendor vendor = Vendor.Find(vendorId);
    //   vendor.AddOrder(order);
    //   return RedirectToAction("Show");
    // }
    // [HttpGet("/vendors/{vendorId}/delete")]
    // public ActionResult Delete(int id)
    // {
    //   Vendor vendor = Vendor.Find(id);
    //   List<Order> orders = Order.GetAllOrders();
    //   for (int i = 0; i < orders.Count; i++)
    //   {
    //     if (orders[i].VendorId == id)
    //     {
    //       orders.Remove(orders[i]);
    //     }
    //   }
    //   Vendor.GetAllVendors().Remove(vendor);
    //   return RedirectToAction("Index");
    // }

    // [HttpGet("/vendors/{vendorId}/orders/{orderId}/delete")]
    // public ActionResult Delete(int vendorId, int orderId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   vendor.DeleteOrder(orderId);
    //   Order.Delete(orderId);
    //   return RedirectToAction("Show");
    // }
  }
}
