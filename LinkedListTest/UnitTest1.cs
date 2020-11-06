using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructures;
using System.Collections.Generic;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedListTest
    {
        /// TC 7.1
        /// <summary>
        /// Givens the element to search in linked list should return true.
        /// </summary>
        [TestMethod]
        public void Given_ElementToSearch_InLinkedList_Should_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Act
            bool result = list.Search(30);
            //Assert
            Assert.AreEqual(true, result);
        }

        /// TC 7.2
        /// <summary>
        /// Givens the element to search in linked list should return false.
        /// </summary>
        [TestMethod]
        public void Given_ElementToSearch_InLinkedList_Should_Return_False()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Act
            bool result = list.Search(1);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}