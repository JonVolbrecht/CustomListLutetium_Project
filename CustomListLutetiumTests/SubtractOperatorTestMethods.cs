using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        



































    }
}
