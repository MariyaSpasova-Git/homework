using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{   
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase (-2, -2)]
    public void Test_CalculateFibonacci_ZeroInput(int inputNumber, int expected)
    {
        // Arrange
      
        // Act
        int actual = Fibonacci.CalculateFibonacci(inputNumber);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int positiveInput = 4;
        int expected = 3;

        // Act
        int actual = Fibonacci.CalculateFibonacci(positiveInput);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}