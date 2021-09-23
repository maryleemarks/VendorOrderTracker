using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public Vendor(string name, string vendorDescription)
    {
      Name = name;
      Description = vendorDescription;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }



  }
}  