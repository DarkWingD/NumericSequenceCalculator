using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeric_Sequence_Calculator.Controllers;

namespace Numeric_Sequence_Calculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private List<int> AllNumberList = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10,11,12,13,14,15};

        [TestMethod]
        public void GetFibonacciSequenceUpTo()
        {
            // Arrange
            HomeController controller = new HomeController();
            var numberList = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            // Act
            var result = controller.GetFibonacciSequenceUpTo(1, 55);

            // Assert
            CollectionAssert.AreEqual(numberList, result);
        }

        [TestMethod]
        public void GetConditionNumbersUpTo()
        {
            // Arrange
            HomeController controller = new HomeController();
            var expectedResult = new List<string> { "1", "2", "C", "4", "E", "C", "7", "8", "C","E","11","C","13","14","Z" };
            // Act
            var result = controller.GetConditionalNumbersUpTo(AllNumberList);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GetEvenNumbersFromList()
        {
            // Arrange
            HomeController controller = new HomeController();
            var expectedResult = new List<int> { 2, 4, 6, 8,10,12,14 };
            // Act
            var result = controller.GetEvenNumbersFromList(AllNumberList);
            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GetOddNumbersFromList()
        {
            // Arrange
            HomeController controller = new HomeController();
            //List contains 3 odd numbers
            var expectedResult = new List<int> { 1, 3, 5, 7, 9,11,13,15 };
            // Act
            var result = controller.GetOddNumbersFromList(AllNumberList);
            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GetNumbersUpTo()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            var result = controller.GetNumbersUpTo(AllNumberList.Last());
            // Assert
            CollectionAssert.AreEqual(result, AllNumberList);
        }

        //private bool AreIntListsEqual(List<int> list1, List<int> list2)
        //{
        //    var firstNotSecond = list1.Except(list2).ToList();
        //    var secondNotFirst = list2.Except(list1).ToList();
        //    return (firstNotSecond.Count == 0 && secondNotFirst.Count == 0);
        //}

    }
}
