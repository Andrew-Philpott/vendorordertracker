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

    public ActionResult Create()
    {
      ViewBag.VendorId = new SelectList(_db.Vendors, "VendorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Order order)
    {
      _db.Orders.Add(order);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Order order = _db.Orders.FirstOrDefault(orders => orders.OrderId == id);
      return View(order);
    }

    public ActionResult Edit(int id)
    {
      var order = _db.Orders.FirstOrDefault(orders => orders.OrderId == id);
      ViewBag.VendorId = new SelectList(_db.Orders, "VendorId", "Name");
      return View(order);
    }

    [HttpPost]
    public ActionResult Edit(Order order)
    {
      _db.Entry(order).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var order = _db.Orders.FirstOrDefault(items => items.OrderId == id);
      return View(order);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var order = _db.Orders.FirstOrDefault(orders => orders.OrderId == id);
      _db.Orders.Remove(order);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}