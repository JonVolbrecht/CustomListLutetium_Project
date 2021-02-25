﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string expected = "123456789";

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
        public void ToString_VerifyCombinationCorrectly()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            string expected = "123";

            //Act
            string actual = test.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_VerifyIfStringListBecomesString()
        {
            //Arrange
            CustomList<string> test = new CustomList<string>();
            string expected = "pizza,poptart,popcorn,";
            string actual;


            //Act
            test.Add("pizza");
            test.Add("poptart");
            test.Add("popcorn");

            actual = test.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


















    }
}
