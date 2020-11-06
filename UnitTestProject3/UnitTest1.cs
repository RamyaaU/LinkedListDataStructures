using LinkedListDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        ///TC 9.1s
        /// <summary>
        /// Givens the element to delete should give new size after deletion true case
        /// </summary>
        [TestMethod]
        public void Given_ElementToDelete_ShouldGiveNewSizeAfterDeletion()
        {
            //Arrange
            int expected = 5;
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(20);
            list.Add(90);
            list.Add(40);
            //Act
            list.Delete(40);
            int result = list.Size();
            //Assert
            Assert.AreEqual(expected, result);
        }

        ///TC 9.2
        /// <summary>
        /// Givens the element to delete should give new size after deletion false case.
        /// </summary>
        [TestMethod]
        public void Given_ElementToDelete_ShouldGiveNewSizeAfterDeletion_FalseCase()
        {
            //Arrange
            int expected = 7;
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(10);
            list.Add(20);
            list.Add(89);
            //Act
            list.Delete(40);
            int result = list.Size();
            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}