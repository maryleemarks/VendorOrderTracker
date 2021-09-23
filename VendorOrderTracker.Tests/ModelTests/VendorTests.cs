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
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescriptionString()
    {
      string name = "Allen's Cafe";
      string description = "cafe on 122nd and Halsey";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorIdInt()
    {
      string name = "Allen's Cafe";
      string description = "cafe on 122nd and Halsey";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsVendors_VendorsList()
    {
      string name1 = "Allen's Cafe";
      string name2 = "Susan's Coffee House";
      string description1 = "cafe on 122nd and Halsey";
      string description2 = "coffee shop on 122nd and Glisan";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Allen's Cafe";
      string name2 = "Susan's Coffee House";
      string description1 = "cafe on 122nd and Halsey";
      string description2 = "coffee shop on 122nd and Glisan";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}