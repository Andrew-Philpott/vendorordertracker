using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
