using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        // Arrange
        int[] numbersInput = Array.Empty<int>();
        int expected = 0;
        
        // Act
        int result = Majority.IsEvenOrOddMajority(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        // Arrange
        int[] numbersInput = new int[] { 0, 0, 0, 0 };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        // Arrange
        int[] numbersInput = new int[] { 8, 9, 13, 4, 10, 33 };
        int expected = 0;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        // Arrange
        int[] numbersInput = new int[] { 44, 22, 3, 5, 70 };
        int expected = 1;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        // Arrange
        int[] numbersInput = new int[] { 4, 13, 9, 2, 7, 1 };
        int expected = -2;

        // Act
        int result = Majority.IsEvenOrOddMajority(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
