using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new() { "level", "deed", "refer" };

        // Act
        bool result = Palindrome.IsPalindrome(inputWords);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emptyInput = new();

        // Act
        bool result = Palindrome.IsPalindrome(emptyInput);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SinglePalindromeWord_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new() { "reviver" };

        // Act
        bool result = Palindrome.IsPalindrome(inputWords);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> inputWords = new() { "bed", "noon", "color", "non" };

        // Act
        bool result = Palindrome.IsPalindrome(inputWords);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> inputWords = new() { "Madam", "kayak", "LEVEL" };

        // Act
        bool result = Palindrome.IsPalindrome(inputWords);

        // Assert
        Assert.IsTrue(result);
    }
}
