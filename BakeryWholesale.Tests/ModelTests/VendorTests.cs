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
    string failType = "This is a string, its type should not match that of a Vendor object";
    Vendor newVendor = new Vendor();
    Assert.AreEqual(typeof(Vendor), failType.GetType());
    }
  }
}