using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests: IDisposable
  {

      public void Dispose()
      {
          Item.ClearAll();
      }


      [TestMethod]
      public void ItemConstructor_CreatesInstanceOfitem_Item()
      {
          Item newItem = new Item("Test");
          Assert.AreEqual(typeof(Item), newItem.GetType());
      }

      [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
        //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      //Act
      string result = newItem.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription__SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      //Act
      string updatedDescription = "Do The Dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;
      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
        //Arrage
        List<Item> newList = new List<Item> { };

        //Act
        List<Item> result = Item.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
    }

  }
}