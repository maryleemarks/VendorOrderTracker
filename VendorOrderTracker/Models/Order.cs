using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public Class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price {get; }
    public DateTime Date { get; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    
  }
}

