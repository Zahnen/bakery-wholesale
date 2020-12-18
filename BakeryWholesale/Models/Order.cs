using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public string OrderDate { get; set; }
    public int OrderPrice { get; set; }
    public int Id { get; } 
    private static List<Order> _orderList = new List<Order> {};

    public Order(string orderName, string orderDescription, int orderPrice, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _orderList.Add(this);
      Id = _orderList.Count;
    }

    public static List<Order> GetOrders()
    {
      return _orderList;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}