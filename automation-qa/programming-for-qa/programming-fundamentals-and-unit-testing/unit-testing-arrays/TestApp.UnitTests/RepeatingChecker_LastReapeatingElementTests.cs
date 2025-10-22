using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] numbersInput = Array.Empty<int>();
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 4 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 20, 10, 9, 8 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        // Arrange
        int[] numbersInput = new int[] { 5, 9, -1, 10, -1, 3 };
        int expected = -1;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        // Arrange
        int[] numbersInput = new int[] { 9, 9, 9 };
        int expected = 9;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoRepeatingValues_ReturnsTheRepeatingValue()
    {
        // Arrange
        int[] numbersInput = new int[] { 4, 18, 9, -6, 9, 13, 90, 13 };
        int expected = 13;

        // Act
        int result = RepeatingChecker.FindLastRepeatingElement(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
