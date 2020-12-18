using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryWholesale.Models;
using System;
using System.Collections.Generic;


namespace BakeryWholesale.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderDate;
      Assert.AreEqual (orderDate, result);
    }

    [TestMethod]
    public void GetOrders_ReturnsListofOrderObjects_OrderList()
    {
      string orderName1 = "TestOrder1";
      string orderDescription1 = "testExample1";
      int orderPrice1 = 8;
      string orderDate1 = "12/18/2020";
      string orderName2 = "TestOrder2";
      string orderDescription2 = "testExample2";
      int orderPrice2 = 10;
      string orderDate2 = "12/18/1992";
      Order newOrder1 = new Order(orderName1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderName2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetOrders();
      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderName = "TestOrder";
      string orderDescription = "testExample";
      int orderPrice = 8;
      string orderDate = "12/18/2020";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName1 = "TestOrder1";
      string orderDescription1 = "testExample1";
      int orderPrice1 = 8;
      string orderDate1 = "12/18/2020";
      string orderName2 = "TestOrder2";
      string orderDescription2 = "testExample2";
      int orderPrice2 = 10;
      string orderDate2 = "12/18/1992";
      Order newOrder1 = new Order(orderName1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderName2, orderDescription2, orderPrice2, orderDate2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}