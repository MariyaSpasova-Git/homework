using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("Wonder", 3, "wOnDeRwOnDeRwOnDeR")]
    [TestCase("Hi Pete", 4, "hI PeTehI PeTehI PeTehI PeTe")]
    [TestCase("Street #165", 2, "sTrEeT #165sTrEeT #165")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = string.Empty;
        int repetionFactor = 2;

        //Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "whatever";
        int repetionFactor = -2;

        //Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "whatever";
        int repetionFactor = 0;

        //Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetionFactor));
    }

    //Bonus
    [Test]
    public void Test_GeneratePatternedString_NullInput_ThrowsArgumentException()
    {
        //Arrange
        string input = null;
        int repetionFactor = 4;

        //Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetionFactor));
    }
}
