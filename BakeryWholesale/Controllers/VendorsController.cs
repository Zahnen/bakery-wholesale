using Microsoft.AspNetCore.Mvc;
using BakeryWholesale.Models;
using System.Collections.Generic;

namespace BakeryWholesale.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(id);
      List<Order> vendorOrders = currentVendor.Orders;
      model.Add("vendor", currentVendor);
      model.Add("order", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorsId}/orders")]
    public ActionResult Create(int vendorsId, string orderName, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor currentVendor = Vendor.Find(vendorsId);
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      currentVendor.AddOrder(newOrder);
      List<Order> vendorOrders = currentVendor.Orders;
      model.Add("order", vendorOrders);
      model.Add("vendor", currentVendor);
      return View("Show", model);
    }
  }
}