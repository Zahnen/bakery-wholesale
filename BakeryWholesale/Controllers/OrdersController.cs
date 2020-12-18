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

    [HttpGet("/orders/{orderId}/orders/new")]
    public ActionResult New(int orderId)
    {
      Order order = Order.Find(orderId);
      return View(order);
    }
  }
}