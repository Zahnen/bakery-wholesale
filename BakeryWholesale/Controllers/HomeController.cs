using Microsoft.AspNetCore.Mvc;
using BakeryWholesale.Models;

namespace BakeryWholesale.Controllers
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