using LinkedListDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        /// TC 8.1
        /// <summary>
        /// Givens the element to search in linked list should return true.
        /// </summary>
        [TestMethod]
        public void Given_ElementToInsertElementInLinkedList_AndCheckIfElementIsInsertedShould_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Insert(3, 40);
            //Act
            bool result = list.Search(30);
            //Assert
            Assert.AreEqual(true, result);
        }

        /// TC 8.2
        /// <summary>
        /// Givens the element to search in linked list should return false.
        /// </summary>
        [TestMethod]
        public void Given_ElementToInsertElementInLinkedList_AndCheckIfElementIsInserted_Should_Return_True()
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Insert(3, 80);
            //Act
            bool result = list.Search(80);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
