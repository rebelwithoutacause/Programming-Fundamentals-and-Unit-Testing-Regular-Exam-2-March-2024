using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        var eraser = new WordEraser();
        List<string> words = new List<string>();
        string wordToErase = "test";

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        /// Arrange
        var eraser = new WordEraser();
        List<string> words = null;
        string wordToErase = "test";

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        // Arrange
        var eraser = new WordEraser();
        List<string> words = new List<string>();
        string wordToErase = "";

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        // Arrange
        var eraser = new WordEraser();
        var words = new List<string> { "erase", "erase", "erase" };
        string wordToErase = "erase";

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        // Arrange
        var eraser = new WordEraser();
        var words = new List<string> { "drink", "erase", "one", "erase", "beer" };
        string wordToErase = "erase";

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual("drink one beer", result);
    }
}

