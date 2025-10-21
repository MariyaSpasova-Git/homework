using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_ZeroInput()
    {
        // Arrange
        long zeroInput = 0;
        long expected = 1;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(zeroInput);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long positiveInput = 11;
        long expected = 11;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(positiveInput);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long positiveInput = 1347;
        long expected = 449;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(positiveInput);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
