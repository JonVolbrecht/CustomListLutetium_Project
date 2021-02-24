using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;



namespace CustomListLutetiumTests
{
    [TestClass]
    public class RemoveMethodTestMethods
    {
        [TestMethod]
        public void Remove_CheckAtIndexZero()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(14);
            test.Add(10);
            int expectedResult = 10;

            //Act
            test.Remove(14);
            int actualResult = test[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }







    }









}
