using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("TestItem", "false", "false", 10, 2);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetItemName_ReturnsItemName_String()
    {
      //Arrange
      string itemName = "Backpack";
      //Act
      Item newItem = new Item(itemName, "false", "true", 10, 2);
      string result = newItem.ItemName;
      //Assert
      Assert.AreEqual(itemName, result);
    }

    [TestMethod]
    public void GetPackedStatus_ReturnsPackedStatus_bool()
    {
      //Arrange
      string itemName = "Backpack";
      string packedStatus = "True";
      //Act
      Item newItem = new Item(itemName, packedStatus, "True", 10, 2);
      bool result = newItem.PackedStatus;
      //Assert
      Assert.AreEqual(result.ToString(), packedStatus);
    }

    [TestMethod]
    public void SetPackedStatus_SetsPackedStatus_Bool()
    {
      //Arrange
      string packedStatus = "True";
      Item newItem = new Item("backpack", packedStatus, "True", 10, 2);
      //Act
      string updatedStatus = "False";
      newItem.PackedStatus = false;
      bool result = newItem.PackedStatus;
      //Assert
      Assert.AreEqual(updatedStatus, result.ToString());
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string itemName = "backpack";
      Item newItem = new Item(itemName, "True", "True", 10, 2);
      //Act
      int result = newItem.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ItemOverloadConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("Jacket", "True");
      //Assert
      Assert.AreEqual(typeof(Item), newItem.GetType());    
    }

    [TestMethod]
    public void GetItemName2_ReturnsItemName2_String()
    {
      //Arrange
      string itemName = "Jacket";
      string packedStatus = "True";
      //Act
      Item newItem = new Item(itemName, packedStatus);
      bool result = newItem.PackedStatus;
      //Assert
      Assert.AreEqual(packedStatus, result.ToString());    
    }    
  }
}