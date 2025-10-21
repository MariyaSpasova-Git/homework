using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
 
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool actual = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(actual, Is.True);
    }

    [TestCase("@abv.bg")]
    [TestCase("didoabv.bg")]
    [TestCase("dido@")]
    public void Test_IsValidEmail_InvalidEmail(string input)
    {
        //Arrange
        
        // Act
        bool actual = Email.IsValidEmail(input);

        // Assert
        Assert.That(actual, Is.False);
    }

    [TestCase (" ")]
    [TestCase (null)]
    public void Test_IsValidEmail_NullInput(string input)
    {
        //Arrange
        
        // Act
        bool actual = Email.IsValidEmail(input);

        // Assert
        Assert.That(actual, Is.False);
    }
}
