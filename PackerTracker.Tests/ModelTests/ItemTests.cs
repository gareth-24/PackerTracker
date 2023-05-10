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
      Item newItem = new Item("testitem", true);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetItemName_ReturnsItemName_String()
    {
      //Arrange
      string itemName = "Backpack";
      //Act
      Item newItem = new Item(itemName, true);
      string result = newItem.ItemName;
      //Assert
      Assert.AreEqual(itemName, result);
    }

    [TestMethod]
    public void GetPackedStatus_ReturnsPackedStatus_Bool()
    {
      //Arrange
      string itemName = "Backpack";
      bool packedStatus = true;
      //Act
      Item newItem = new Item(itemName, packedStatus);
      bool result = newItem.PackedStatus;
      //Assert
      Assert.AreEqual(result, packedStatus);
    }

    [TestMethod]
    public void SetPackedStatus_SetsPackedStatus_Bool()
    {
      //Arrange
      bool packedStatus = true;
      Item newItem = new Item("backpack", packedStatus);
      //Act
      bool updatedStatus = false;
      newItem.PackedStatus = updatedStatus;
      bool result = newItem.PackedStatus;
      //Assert
      Assert.AreEqual(updatedStatus, result);
    }
  }
}