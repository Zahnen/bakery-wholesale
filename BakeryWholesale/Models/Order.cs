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

    public Order(string orderName, string orderDescription, int orderPrice, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
    }
  }
}