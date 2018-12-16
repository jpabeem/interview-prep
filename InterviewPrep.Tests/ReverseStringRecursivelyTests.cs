using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class ReverseStringRecursivelyTests
    {
        [TestMethod]
        public void ReverseStringRecursivelyShouldReverseCorrectly_Testcase_1()
        {
            // Arrange
            string input = "lepel";

            // Act
            var reversedInput = ReverseStringRecursively.Reverse(input);

            // Assert
            Assert.AreEqual("lepel", reversedInput);
        }

        [TestMethod]
        public void ReverseStringRecursivelyShouldReverseCorrectly_Testcase_2()
        {
            // Arrange
            string input = "vork";

            // Act
            var reversedInput = ReverseStringRecursively.Reverse(input);

            // Assert
            Assert.AreEqual("krov", reversedInput);
        }

        [TestMethod]
        public void ReverseStringRecursivelyShouldReverseCorrectly_Testcase_3()
        {
            // Arrange
            string input = "flytoohigh";

            // Act
            var reversedInput = ReverseStringRecursively.Reverse(input);

            // Assert
            Assert.AreEqual("hgihootylf", reversedInput);
        }
    }
}
