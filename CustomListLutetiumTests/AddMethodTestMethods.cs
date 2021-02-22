using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;

namespace CustomListLutetiumTests
{
    [TestClass]
    public class AddMethodTestMethods
    {
        [TestMethod]
        public void Add_VerifyCountAddition()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            actual = test.Add(2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Add_VerifyIndexValueZero()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            actual = test.Add(expected);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Add_VerifyIndexValueOne()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            int expected1 = 2;
            int expected2 = 16
            
            //Act


            //Assert
        }










    }
}
