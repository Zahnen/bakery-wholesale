using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }

    public Order(string orderName, string orderDescription, int orderPrice)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
    }
  }
}