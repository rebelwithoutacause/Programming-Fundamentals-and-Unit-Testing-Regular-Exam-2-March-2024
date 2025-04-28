using NUnit.Framework;
using System.ComponentModel;

namespace TestApp.Tests
{
    public class HashTagCheckerTests
    {
        [Test]
        public void Test_GetHashTags_ValidTextWithOneHashTag_ReturnMessageForOneHashTags()
        {
            // Arrange
            string text = "#QA - mastering the unit testing";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            // Assert
            Assert.AreEqual("Only one! You know exactly what you #tag.", result);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForEvenHashTags()
        {
            string text = "Coding world";

            string hashTagsNumber = "";

            string result = HashTagChecker.GetHashTags(text);

            Assert.AreEqual("The text does not contain #tags.", result);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForOddHashTags()
        {
            string text = "#SoftUni have QA courses.";
             
            string result = HashTagChecker.GetHashTags(text);

            Assert.AreEqual("Only one! You know exactly what you #tag.", result);
        }

        [Test]
        public void Test_GetHashTags_NullOrEmptyText_ReturnsErrorMessage()
        {
            string text = null;

            string result = HashTagChecker.GetHashTags(text);

            Assert.AreEqual("No content...", result);
        }

        [Test]
        public void Test_GetHashTags_TestWithoutHashTags_ReturnsErrorMessage()
        {
            string text = "Hello";

            string result = HashTagChecker.GetHashTags(text);

            Assert.AreEqual("The text does not contain #tags.", result);
        }
    }
}

