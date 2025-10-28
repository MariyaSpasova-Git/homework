using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 1, 9, 25 };
        List<double> expected = new() { 1, 3, 5 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<double> expected = new() { 0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new();

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(input, actual);
    }

    [Test]
    public void Test_ProcessNumbers_ListWithEvenAndOddsNumbers_ReturnsCorrectResult()
    {
        // Arrange
        List<int> input = new() { 9, 4, 49, 81, 10 };
        List<double> expected = new() { 3, 16, 7, 9, 100 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_OddNumbersThatAreNotEqualSquare_ReturnsCorrectResult()
    {
        // Arrange
        List<int> input = new() { 7, 13 };
        List<double> expected = new() { 2.64, 3.60 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);
        double firstElementInResult = Math.Round(actual[0], 2);
        double secondElementInResult = Math.Round(actual[1], 2);

        // Assert
        Assert.That(firstElementInResult, Is.EqualTo(expected[0]).Within(0.01));
        Assert.That(secondElementInResult, Is.EqualTo(expected[1]).Within(0.01));
    }
}
