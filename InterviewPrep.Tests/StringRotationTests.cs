using InterviewPrep.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep.Tests
{
    [TestClass]
    public class StringRotationTests
    {
        [TestMethod]
        public void StringRotationShouldSuccessfullyCheckIfStringIsARotation_Testcase_1()
        {
            // Arrange
            string original = "surreal";
            string rotation = "alsurre";

            // Act
            bool output = StringRotation.IsSubstring(rotation, original);

            // Assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void StringRotationShouldSuccessfullyCheckIfStringIsARotation_Testcase_2()
        {
            // Arrange
            string original = "electric";
            string rotation = "tricelec";

            // Act
            bool output = StringRotation.IsSubstring(rotation, original);

            // Assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void StringRotationShouldSuccessfullyCheckIfStringIsARotation_Testcase_3()
        {
            // Arrange
            string original = "spotify";
            string rotation = "yfitops";

            // Act
            bool output = StringRotation.IsSubstring(rotation, original);

            // Assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void StringRotationShouldSuccessfullyCheckIfStringIsARotation_Testcase_4()
        {
            // Arrange
            string original = "test";
            string rotation = "tests";

            // Act
            bool output = StringRotation.IsSubstring(rotation, original);

            // Assert
            Assert.AreEqual(false, output);
        }
    }
}
