using System;
using System.Collections.Generic;

namespace BakeryWholesale.Models
{
  public class Order
  {
    public string OrderName { get; set; }

    public Order(string orderName)
    {
      OrderName = orderName;
    }
  }
}