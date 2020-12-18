using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryWholesale.Models;
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
    Order newOrder = new Order("testName", "testDescription");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderTitle_String()
    {
      string orderName = "TestOrder";
      Order newOrder = new Order(orderName, "testDescription");
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderDescription_String()
    {
      string orderName = "TestOrder";
      string orderDescription = "testExample";
      string failOrderDescription = "This is an example to compare to the string orderDescription for a failed test";
      Order newOrder = new Order(orderName, orderDescription);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(failOrderDescription, result);
    }
  }
}