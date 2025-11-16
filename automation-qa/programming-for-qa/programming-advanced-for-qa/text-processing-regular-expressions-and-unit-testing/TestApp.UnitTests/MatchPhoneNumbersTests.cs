using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "You can contact us at +359-2-124-5678, +359 2 986 5432, and +359-2-555-5555.";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Look for number +35921234567")]
    [TestCase("The number +359 21234567 is closed")]
    [TestCase("I called +359 2 1234567")]
    [TestCase("Reaching +359 2 1234 567 is impossible!")]
    [TestCase("Sent message to +359 21 123 4567")]
    [TestCase("Call at +359 2 1234 5678")]
    [TestCase("The number 359 2 123 5678 is not responding")]
    [TestCase("The number +359-2 123 5678 is not responding")]
    [TestCase("One message from 00359 2 123 5678")]
    [TestCase("My old number is +359 (2) 123 5678")]
    [TestCase("My new number is +359_2_123_5678")]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString(string phoneNumbers)
    {
        // Arrange
        
        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = string.Empty;

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "Note down the numbers +359-2-123-7890, +35929865432, +359-2-333-3334, and 359 2 789 0123.";
        string expected = "+359-2-123-7890, +359-2-333-3334";

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
