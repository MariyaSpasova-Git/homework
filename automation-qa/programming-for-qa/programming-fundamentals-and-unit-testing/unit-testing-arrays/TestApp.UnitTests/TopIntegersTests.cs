using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    private TopIntegers instance;

    [SetUp]
    public void SetUp()
    {
        instance = new TopIntegers();
    }

    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] numbersInput = Array.Empty<int>();
        
        // Act
        string result = instance.FindTopIntegers(numbersInput);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] numbersInput = new int[] { 45, 34, 20, 8 };
        string expected = "45 34 20 8";
        
        // Act
        string result = instance.FindTopIntegers(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] numbersInput = new int[] { 3 };
        string expected = "3";
        
        // Act
        string result = instance.FindTopIntegers(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] numbersInput = new int[] { 8, 12, 9, 3, 5 };
        string expected = "12 9 5";
        
        // Act
        string result = instance.FindTopIntegers(numbersInput);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

