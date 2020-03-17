using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

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
    public ActionResult New()
    {
      return View();
    }

    [HttpPost]
    public ActionResult New(Vendor vendor, string arrayJson)
    {
      List<string> array = JsonConvert.DeserializeObject<List<string>>(arrayJson);
      _db.Vendors.Add(vendor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Vendor vendor = _db.Vendors.FirstOrDefault(vendors => vendors.VendorId == id);
      return View(vendor);
    }

    public ActionResult Delete(int id)
    {
      Vendor vendor = _db.Vendors.FirstOrDefault(vendors => vendors.VendorId == id);
      return View(vendor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var vendor = _db.Vendors.FirstOrDefault(vendors => vendors.VendorId == id);
      _db.Vendors.Remove(vendor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
