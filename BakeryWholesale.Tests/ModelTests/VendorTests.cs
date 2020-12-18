using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryWholesale.Models;
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
    Vendor newVendor = new Vendor("test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReturnsVendorName()
    {
      string vendorName = "TestVendor";
      string failName = "This is an example to compare to the string vendorName for a failed test";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.VendorName;
      Assert.AreEqual(failName, result);
    }
  }
}