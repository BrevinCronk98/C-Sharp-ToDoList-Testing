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

        // Test One
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfitem_Item()
        {
            Item newItem = new Item("Test");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        // Test Two
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

        // Test Three
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

        // Test Four
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            //Arrage
            List<Item> newList = new List<Item> { };

            //Act
            List<Item> result = Item.GetAll();

            // //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        // Test Five
        [TestMethod]
        public void GetAll_ReturnItems_ItemList()
        
        {
            // Arrange
            string description1 = "Wash the Dog";
            string description2 = "Walk the Dishes";
            Item newItem1 = new Item(description1);
            Item newItem2 = new Item(description2);
            List<Item> newList = new List<Item> {newItem1, newItem2};

            // Act
            List<Item> result = Item.GetAll();
            
            // Assert
            CollectionAssert.AreEqual(newList, result);
        }


    }
}