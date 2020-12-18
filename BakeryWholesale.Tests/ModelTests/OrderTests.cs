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
    Order newOrder = new Order("testName", "testDescription", 8, "12/18/2020");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderTitle_String()
    {
      string orderName = "TestOrder";
      Order newOrder = new Order(orderName, "testDescription", 8, "12/18/2020");
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderDescription_String()
    {
      string orderName = "TestOrder";
      string orderDescription = "testExample";
      Order newOrder = new Order(orderName, orderDescription, 8, "12/18/2020");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderPrice_Int()
    {
      string orderName = "TestOrder";
      string orderDescription = "testExample";
      int orderPrice = 8;
      Order newOrder = new Order(orderName, orderDescription, orderPrice, "12/18/2020");
      int result = newOrder.OrderPrice;
      Assert.AreEqual(orderPrice, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsOrderDate_String()
    {
      string orderName = "TestOrder";
      string orderDescription = "testExample";
      int orderPrice = 8;
      string orderDate = "12/18/2020";
      string failDate = "12/18/1992";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderDate;
      Assert.AreEqual (failDate, result);
    }
  }
}