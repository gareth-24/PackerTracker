using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("testitem");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetItemName_ReturnsItemName_String()
    {
      //Arrange
      string itemName = "Backpack";
      //Act
      Item newItem = new Item(itemName);
      string result = newItem.ItemName;
      //Assert
      Assert.AreEqual(itemName, result);
    }
  }
}