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
            int itemsToRemove = 4;
            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3;

            test1.Add( 1, 3, 5, 7 );
            
            test2.Add( 2, 4, 6, 8 );
            
            int expectedResult = 0;

            //Act
            test3 = test1 - test2;
            int actualResult = test3[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }





































    }
}
