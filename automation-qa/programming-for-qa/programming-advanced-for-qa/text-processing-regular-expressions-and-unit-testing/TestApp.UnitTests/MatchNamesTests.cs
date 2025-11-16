using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        // Arrange
        string names = "Miriam Johnson is talking to John Wayne";
        string expected = "Miriam Johnson John Wayne";

        // Act
        string result = MatchNames.Match(names);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    public void Test_Match_NamesWithDash_ReturnsPartialMatchedNames()
    {
        // Arrange
        string text = "I met Mary-Jane Watson";
        string expected = "Jane Watson";

        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // Arrange
        string text = "I live in Athens";
        
        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string text = string.Empty;

        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_NamesWithApostrophe_ReturnsEmptyString()
    {
        // Arrange
        string text = "My name is John O'Malley";

        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    public void Test_Match_NamesWithInvalidSpacing_ReturnsEmptyString()
    {
        // Arrange
        string text = "He is Kiril  Boychev";

        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [TestCase("Are you sure she is Ava MAX?")]
    [TestCase("I spoke to Mr. ALEXANDER KOSTOV")]
    [TestCase("Look at Billy JAne")]
    [TestCase("michael jackson was great")]
    public void Test_Match_NamesWithIncorrectCapitalization_ReturnsEmptyString(string text)
    {
        // Arrange

        // Act
        string result = MatchNames.Match(text);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
