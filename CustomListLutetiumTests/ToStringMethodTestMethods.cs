using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListLutetium;


namespace CustomListLutetiumTests
{
    [TestClass]
    class ToStringMethodTestMethods
    {
        [TestMethod]
        public void ToString_VerifyConversionToStrings()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();

            int itemsToAdd = 10;
            string expected = "{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }";

            for (int i = 0; i < itemsToAdd; i++)
            {
                test.Add(i);
            }

            //Act
            string actual = test.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]






















    }
}
