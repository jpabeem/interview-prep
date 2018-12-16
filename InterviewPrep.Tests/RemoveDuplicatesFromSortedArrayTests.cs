using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayShouldCorrectlyRemoveDuplicatesAndReturnNewLength_Testcase_1()
        {
            // Arrange
            var sortedArray = new int[] { 1, 3, 3, 5, 7, 8, 10, 11, 11, 14, 16, 16 };

            // Act
            int sortedArrayWithoutDuplicatesLength = RemoveDuplicatesFromSortedArray.GetLengthWithoutDuplicates(sortedArray);

            // Assert
            Assert.AreEqual(9, sortedArrayWithoutDuplicatesLength);
        }

        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayShouldCorrectlyRemoveDuplicatesAndReturnNewLength_Testcase_2()
        {
            // Arrange
            var sortedArray = new int[] { 2, 2, 3, 3, 4, 7, 8, 9, 9, 18, 18, 26, 29, 29 };

            // Act
            var sortedArrayWithoutDuplicatesLength = RemoveDuplicatesFromSortedArray.GetLengthWithoutDuplicates(sortedArray);

            // Assert
            Assert.AreEqual(9, sortedArrayWithoutDuplicatesLength);
        }

        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayShouldCorrectlyRemoveDuplicatesAndReturnNewLength_Testcase_3()
        {
            // Arrange
            var sortedArray = new int[] { 5, 5, 6, 6, 7, 7, 8, 8, 9 };

            // Act
            var sortedArrayWithoutDuplicatesLength = RemoveDuplicatesFromSortedArray.GetLengthWithoutDuplicates(sortedArray);

            // Assert
            Assert.AreEqual(5, sortedArrayWithoutDuplicatesLength);
        }
    }
}
