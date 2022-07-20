using Microsoft.AspNetCore.Mvc;

namespace Nursery.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}