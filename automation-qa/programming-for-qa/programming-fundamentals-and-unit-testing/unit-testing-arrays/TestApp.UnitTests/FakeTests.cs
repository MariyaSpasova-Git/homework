using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] charInput = new char[] { 'B', '2', '=', '3', 'Y' };
        char[] expected = new char[] { 'B', '=', 'Y' };

        //Act
        char[] result = Fake.RemoveStringNumbers(charInput);

        //Assert
        CollectionAssert.AreEqual(result, expected);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] charInput = new char[] { 'a', '!', 'C' };

        //Act
        char[] result = Fake.RemoveStringNumbers(charInput);

        //Assert
        CollectionAssert.AreEqual(result, charInput);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        char[] charInput = Array.Empty<char>();

        //Act
        char[] result = Fake.RemoveStringNumbers(charInput);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveStringNumbers_OnlyDigitsInput_ReturnsEmptyArray()
    {
        //Arrange
        char[] charInput = new char[] { '9', '0', '3', '3' };

        //Act
        char[] result = Fake.RemoveStringNumbers(charInput);

        //Assert
        Assert.That(result, Is.Empty);
    }
}
