﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumTests
{
    [TestClass]
    class SubtractOperatorTestMethods
    {
        [TestMethod]
        public void SubtractOperator_VerifyListsCombineAtIndexZero()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;

            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test1.Add(7);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);

            //Act
            test3 = test1 - test2;
            int expected = 0;
            int actual = test3[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_VerifyListsSubtractAtIndexOne()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;

            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test1.Add(7);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test2.Add(8);
            test2.Add(10);
            test2.Add(12);

            int expectedResult = 12;

            //Act
            test3 = test1 - test2;
            int expected = 12;
            int actual = test3[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_VerifyCountOfListsDecrease()
        {
            //Arrange
            int itemsToAdd = 40;
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test3;

            for (int i = 0; i < itemsToAdd; i++)
            {
                test1.Add(i);
            }
            var test2 = new CustomList<int>() { 2, 3, 4, 5 };

            //Act
            test3 = test1 - test2;

            //Assert
            int expected = test1.Count - test2.Count;
            int actual = test3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_VerifyTwoListsSubtractOneItem()
        {
            //Arrange
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            int actual;


            //Act
            test1.Add(236);
            test1.Add(234);
            test2.Add(234);
            test3 = test1 - test2;
            actual = test3[0];

            //Assert
            int expected = 236;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOperator_VerifyEmptyListDoesntChangeIndexTwo()
        {
            // Arrange
            CustomList<int> test1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;
            int expected = 3;
            int actual;

            // Act
            test3 = test1 - test2;

            // Assert
            actual = test3[2];
            Assert.AreEqual(expected, actual);


        }


    }
}
