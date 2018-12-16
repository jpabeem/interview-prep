using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class StringCompressionTests
    {

        [TestMethod]
        public void StringCompressionShouldCompressStringSuccessfully_Testcase_1()
        {
            // Arrange
            string input = "aabcccccaaa";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("a2b1c5a3", output);
        }

        [TestMethod]
        public void StringCompressionShouldCompressStringSuccessfully_Testcase_2()
        {
            // Arrange
            string input = "aabbccc";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("a2b2c3", output);
        }

        [TestMethod]
        public void StringCompressionShouldCompressStringSuccessfully_Testcase_3()
        {
            // Arrange
            string input = "hhhhbboooooaaa";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("h4b2o5a3", output);
        }

        [TestMethod]
        public void StringCompression_ShouldNotReturnACompressedString_WhenTheCompressedStringIsNotSmallerThanTheOriginalString_Testcase_1()
        {
            // Arrange
            string input = "aa";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("aa", output);
        }

        [TestMethod]
        public void StringCompression_ShouldNotReturnACompressedString_WhenTheCompressedStringIsNotSmallerThanTheOriginalString_Testcase_2()
        {
            // Arrange
            string input = "aabbccddeeffgghhiijjkk";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("aabbccddeeffgghhiijjkk", output);
        }

        [TestMethod]
        public void StringCompression_ShouldNotReturnACompressedString_WhenTheCompressedStringIsNotSmallerThanTheOriginalString_Testcase_3()
        {
            // Arrange
            string input = "abcdefghijklmnopqrstuvwqyz";

            // Act
            string output = StringCompression.Compress(input);

            // Assert
            Assert.AreEqual("abcdefghijklmnopqrstuvwqyz", output);
        }
    }
}
