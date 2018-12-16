using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class SingleNumberTests
    {
        [TestMethod]
        public void SingleNumberShouldFindUniqueElementInArray_Testcase_1()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 8, 15, 15, 56, 56, 98, 98 };

            // Act
            int uniqueNumberInArray = SingleNumber.FindUnique(inputArray);

            // Assert
            Assert.AreEqual(3, uniqueNumberInArray);
        }

        [TestMethod]
        public void SingleNumberShouldFindUniqueElementInArray_Testcase_2()
        {
            // Arrange
            var inputArray = new int[] { 9, 9, 20, 20, 25, 25, 30, 30, 71, 71, 122, 122, 150 };

            // Act
            int uniqueNumberInArray = SingleNumber.FindUnique(inputArray);

            // Assert
            Assert.AreEqual(150, uniqueNumberInArray);
        }

        [TestMethod]
        public void SingleNumberShouldFindUniqueElementInArray_Testcase_3()
        {
            // Arrange
            var inputArray = new int[] { 9, 9, 20, 20, 25, 25, 30, 30, 71, 71, 122, 122, 150, 150 };

            // Act
            int uniqueNumberInArray = SingleNumber.FindUnique(inputArray);

            // Assert
            Assert.AreEqual(0, uniqueNumberInArray);
        }
    }
}
