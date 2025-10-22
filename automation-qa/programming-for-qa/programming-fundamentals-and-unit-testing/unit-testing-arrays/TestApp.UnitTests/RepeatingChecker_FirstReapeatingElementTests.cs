using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = Array.Empty<int>();
        int expected = -1;
        
        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 25 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 3, 7, 10, 78, 0 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoRepeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 7, -1, 10, -1 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] numbersInput = new int[] { 3, 3, 3, 3 };
        int expected = 3;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoRepeatingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] numbersInput = new int[] { 1, 20, 5, 7, 20, 8, 20 };
        int expected = 20;

        // Act
        int result = RepeatingChecker.FindFirstRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
