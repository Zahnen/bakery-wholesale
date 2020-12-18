using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}