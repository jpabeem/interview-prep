using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class MergeTwoSortedArraysTests
    {
        [TestMethod]
        public void TwoSortedArraysShouldMergeCorrectly_Testcase_1()
        {
            // Arrange
            var arrayOne = new int[] { 3, 8, 15, 56, 98 };
            var arrayTwo = new int[] { 14, 34, 67, 70, 89 };

            // Act
            var sortedArray = MergeTwoSortedArrays.Merge(arrayOne, arrayTwo);

            // Assert
            CollectionAssert.AreEqual(new int[] { 3, 8, 14, 15, 34, 56, 67, 70, 89, 98 }, sortedArray);
        }

        [TestMethod]
        public void TwoSortedArraysShouldMergeCorrectly_Testcase_2()
        {
            // Arrange
            var arrayOne = new int[] { 1, 5, 19, 25, 33, 47 };
            var arrayTwo = new int[] { 6, 12, 29, 40, 57 };

            // Act
            var sortedArray = MergeTwoSortedArrays.Merge(arrayOne, arrayTwo);

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 5, 6, 12, 19, 25, 29, 33, 40, 47, 57 }, sortedArray);
        }

        [TestMethod]
        public void TwoSortedArraysShouldMergeCorrectly_Testcase_3()
        {
            // Arrange
            var arrayOne = new int[] { 10, 25, 36, 43, 52, 74, 104};
            var arrayTwo = new int[] { 5, 15, 28, 37, 49, 56, 89, 109 };

            // Act
            var sortedArray = MergeTwoSortedArrays.Merge(arrayOne, arrayTwo);

            // Assert
            CollectionAssert.AreEqual(new int[] { 5, 10, 15, 25, 28, 36, 37, 43, 49, 52, 56, 74, 89, 104, 109 }, sortedArray);
        }
    }
}
