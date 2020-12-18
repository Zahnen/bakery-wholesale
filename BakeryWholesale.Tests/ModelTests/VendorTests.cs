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
    Vendor newVendor = new Vendor("test", "test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReturnsVendorName_String()
    {
      string vendorName = "TestVendor";
      Vendor newVendor = new Vendor(vendorName, "test");
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void VendorConstructor_ReturnsVendorDescription_String()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "testExampleDescription";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.VendorDescription;
      Assert.AreEqual(vendorDescription, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "testExample";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}