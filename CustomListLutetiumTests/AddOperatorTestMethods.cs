using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumTests
{
    [TestClass]
    class AddOperatorTestMethods
    {
        [TestMethod]
        public void AdditionOperator_VerifyListsCombineAtIndexOne()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test2.Add(4);
            test2.Add(5);
            test2.Add(6);
            int expected = 2;

            //Act
            test3 = test1 + test2;
            int actual = test3[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOperator_CombineTwoEmptyLists_CountIsZero()
        {
            // Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            int expected = test2.Count + test1.Count;

            // Act
            test3 = test2 + test1;

            // Assert
            int actual = test3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOperator_VerifyCountEqualsBothLists()
        {
            // Arrange
            int itemsToAdd = 10;
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            for (int i = 0; i < itemsToAdd; i++)
            {
                test1.Add(i);
            }
            for (int i = 0; i < itemsToAdd; i++)
            {
                test2.Add(i * 10);
            }

            // Act
            test3 = test1 + test2;

            // Assert
            int expected = test1.Count + test2.Count;
            int actual = test3.Count;
            Assert.AreEqual(expected, actual);
        }












    }
}
