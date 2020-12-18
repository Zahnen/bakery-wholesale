using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor> {};

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _vendorList.Add(this);

    }
    public static List<Vendor> GetVendors()
    {
      return _vendorList;
    }
    public static void ClearAll()
    {
      _vendorList.Clear();
    }

  }
}