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
            CustomList<int> test3;
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
            CustomList<int> test3;
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

        [TestMethod]
        public void AdditionOperator_VerifyListsCombineIndexThree()
        {
            // arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            int expected = 237;
            int acutual;

            // act
            test1.Add(234);
            test1.Add(235);
            test1.Add(236);
            test2.Add(237);
            test2.Add(238);
            test2.Add(239);
            test3 = test1 + test2;
            acutual = test3[3];

            // assert
            Assert.AreEqual(expected, acutual);
        }

        [TestMethod]
        public void AdditionOperator_VerifyCountRemainsEqual()
        {
            // Arrange
            int itemsToAdd = 40;
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;

            for (int i = 0; i < itemsToAdd; i++)
            {
                test1.Add(i);
            }

            // Act
            test3 = test1 + test2;

            // Assert
            int expected = test1.Count;
            int actual = test3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOperator_VerifyListsCombineCounts()
        {
            //Arrange
            int itemsToAdd = 20;
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;

            for (int i = 0; i < itemsToAdd; i++)
            {
                test1.Add(i);
            }
            for (int i = 0; i < (itemsToAdd * 3); i++)
            {
                test2.Add(i);
            }

            //Act
            test3 = test1 + test2;


            //Assert
            int expected = test2.Count + test1.Count;
            int actual = test3.Count;
            Assert.AreEqual(expected, actual);

        }





    }
}
