using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;



namespace CustomListLutetiumTests
{
    [TestClass]
    public class RemoveMethodTestMethods
    {
        [TestMethod]
        public void Remove_VerifyAtIndexZero()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(14);
            test.Add(10);
            int expected = 10;


            //Act
            test.Remove(14);
            int actual = test[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_VerifyAtIndexSeven()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(10);
            test.Add(11);
            test.Add(12);
            test.Add(13);
            test.Add(14);
            test.Add(15);
            test.Add(16);
            test.Add(17);
            test.Add(18);
            int expected = 18;

            //Act
            test.Remove(17);
            int actual = test[7];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_



    }









}
