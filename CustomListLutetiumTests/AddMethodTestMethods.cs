using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumTests
{
    [TestClass]
    public class AddMethodTestMethods
    {
        [TestMethod]
        public void Add_VerifyAdditionToList()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int value = 1;
            int actual;

            //Act
            test.Add(value);
            actual = test.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Add_VerifyIndexValueZero()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 2;
            int value = 2;
            int actual;

            //Act
            test.Add(value);
            actual = test[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Add_VerifyIndexValueOne()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected1 = 2;
            int expected2 = 20;
            int value = 2;
            int value2 = 20;
            int actual;
            int actual2;

            //Act
            test.Add(value);
            test.Add(value2);
            actual = test[1];

            //Assert
            Assert.AreEqual(expected2, test[1]);

        }

        public void Add_VerifyIndexValueSix()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int expected2 = 2;
            int expected3 = 3;
            int expected4 = 4;
            int expected5 = 5;
            int expected6 = 6;
            int expected7 = 7;
            int value = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int actual;

            //Act
            test.Add(value);
            test.Add(value2);
            test.Add(value3);
            test.Add(value4);
            test.Add(value5);
            test.Add(value6);
            test.Add(value7);
            actual = test[6];


            //Assert
            Assert.AreEqual(expected7, test[6]);

        }

        public void Add_VerifyIndexValue1() // test that the capacity of your array doubles when you add one more than
            // the initial capacity
        {
            //Arrange
            CustomList<string> fruits = new CustomList<string>();
            string expected = "Apple";
            string expected2 = "Pear";
            string expected3 = "Orange";
            string actual;

            //Act
            actual = fruits.Add(expected);
            actual = fruits.Add(expected2);
            actual = fruits.Add(expected3);

            //Assert
            Assert.AreEqual(expected2, fruits[2]);

        }






    }
}
