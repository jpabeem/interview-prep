using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class RotateArrayKTimesTests
    {
        [TestMethod]
        public void RotateArrayKTimesToTheRightShouldRotateArrayCorrectly_Testcase_1()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 1;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateRight(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 98, 3, 8, 15, 56 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheRightShouldRotateArrayCorrectly_Testcase_2()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 3;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateRight(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 15, 56, 98, 3, 8 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheRightShouldRotateArrayCorrectly_Testcase_3()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 5;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateRight(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 3, 8, 15, 56, 98 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheRightShouldRotateArrayCorrectly_Testcase_4()
        {
            // Arrange
            var inputArray = new int[] { };
            int kTimes = 1;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateRight(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheLeftShouldRotateArrayCorrectly_Testcase_1()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 1;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateLeft(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 8, 15, 56, 98, 3 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheLeftShouldRotateArrayCorrectly_Testcase_2()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 3;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateLeft(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 56, 98, 3, 8, 15 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheLeftShouldRotateArrayCorrectly_Testcase_3()
        {
            // Arrange
            var inputArray = new int[] { 3, 8, 15, 56, 98 };
            int kTimes = 5;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateLeft(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { 3, 8, 15, 56, 98 }, rotatedArray);
        }

        [TestMethod]
        public void RotateArrayKTimesToTheLeftShouldRotateArrayCorrectly_Testcase_4()
        {
            // Arrange
            var inputArray = new int[] { };
            int kTimes = 5;

            // Act
            var rotatedArray = RotateArrayKTimes.RotateLeft(inputArray, kTimes);

            // Assert
            CollectionAssert.AreEqual(new int[] { }, rotatedArray);
        }
    }
}
