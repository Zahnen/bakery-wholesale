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
    string failType = "This is a string, its type should not match that of an Order object";
    Order newOrder = new Order();
    Assert.AreEqual(typeof(Order), failType.GetType());
    }
  }
}