using NUnit.Framework;
using System.Threading;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("user@domain.com")]
    [TestCase("a@b.cd")]
    [TestCase("new-user@domain.co")]
    [TestCase("old+user.@domain.go")]
    [TestCase("great.user@domain.net")]
    [TestCase("user_John@domain.com")]
    [TestCase("user%school@domain.uk")]
    [TestCase("user123@domain.com")]
    [TestCase("user@123domain.ny")]
    [TestCase("user@new-domain.hog")]
    [TestCase("user@domain.go.com")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@longdomain.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("domain.com")]
    [TestCase("user@domain")]
    [TestCase("user@.net")]
    [TestCase("@domain.hot")]
    [TestCase("onlyusername@")]
    [TestCase("user@domain.")]
    [TestCase("user#one@domain.it")]
    [TestCase("user@doman&work.com")]
    [TestCase("user@domain.net!")]
    [TestCase("*useer@christmas.2025")]
    [TestCase("user@do@main.com")]

    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
