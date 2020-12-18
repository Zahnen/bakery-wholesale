using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryWholesale.Models;
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
    public void GetVendors_ReturnsListofVendorObjects_VendorList()
    {
      string vendorName1 = "TestVendor1";
      string vendorDescription1 = "testExample1";
      string vendorName2 = "TestVendor2";
      string vendorDescription2 = "testExample2";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetVendors();
      CollectionAssert.AreEqual(newVendorList, result);
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
    [TestMethod]
    public void AddOrder_AssociatesOrderObjectInListWithinVendorObject_OrderList()
    {
    string vendorName = "TestVendor";
    string vendorDescription = "testExample";
    string orderName = "TestOrder1";
    string orderDescription = "testExample1";
    int orderPrice = 8;
    string orderDate = "12/18/2020";
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
    List<Order> newList = new List<Order> { newOrder };
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "Test Vendor";
      string vendor2 = "Test Vendor Also";
      string vendorDescription1 = "Test Example";
      string vendorDescription2 = "Test Example also";
      Vendor newVendor1 = new Vendor(vendor1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendor2, vendorDescription2);
      Vendor failVendor = new Vendor("This should", "fail because it a different Vendor object than the one with an ID of 2");

      Vendor result = Vendor.Find(2);
      Assert.AreEqual(failVendor, result);
    }
  }
}