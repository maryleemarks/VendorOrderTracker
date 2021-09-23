using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsVendorNameString()
    {
      string name = "Allen's Cafe";
      string description = "cafe on 122nd and Halsey";
      Vendor newVendow = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
  }
}