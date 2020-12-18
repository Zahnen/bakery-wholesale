using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; } 
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public List<Order> Orders { get; set; }


    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order>{};


    }
    public static List<Vendor> GetVendors()
    {
      return _vendorList;
    }
    public static void ClearAll()
    {
      _vendorList.Clear();
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}