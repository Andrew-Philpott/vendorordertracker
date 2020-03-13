using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
