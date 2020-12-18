using Microsoft.AspNetCore.Mvc;
using BakeryWholesale.Models;

namespace BakeryWholesale.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}