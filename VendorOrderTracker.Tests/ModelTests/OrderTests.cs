using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests 
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
      Order NewOrder = new Order("test", "test description", 99, DateTime.Today);
      Assert.AreEqual(typeof(Order), NewOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitleString()
    {
      string title = "Allen Reg";
      string description = "10 loaves";
      int price = 35;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescriptionString()
    {
      string title = "Allen Reg";
      string description = "10 loaves";
      int price = 35;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceInt()
    {
      string title = "Allen Reg";
      string description = "10 loaves";
      int price = 35;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDateDate()
    {
      string title = "Allen Reg";
      string description = "10 loaves";
      int price = 35;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      DateTime result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void SetTitle_SetTitleString()
    {
      string title = "Allen Reg";
      string description = "10 loaves";
      int price = 35;
      DateTime date = DateTime.Today;
      Order newOrder = new Order(title, description, price, date);
      string updatedTitle = "Allen's Cafe Standing Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
  }
}