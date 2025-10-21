using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string emptyInput = string.Empty;
        string expected = "Empty string";

        //Act
        string actual = MiddleCharacters.GetMiddleChars(emptyInput);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string whiteSpaceInput = " ";
        string expected = "Empty string";

        //Act
        string actual = MiddleCharacters.GetMiddleChars(whiteSpaceInput);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        //Arrange
        string SingleCharInput = "A";
        string expected = "A";

        //Act
        string actual = MiddleCharacters.GetMiddleChars(SingleCharInput);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        //Arrange
        string EvenStringLengthInput = "Midnight";
        string expected = "ni";

        //Act
        string actual = MiddleCharacters.GetMiddleChars(EvenStringLengthInput);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        //Arrange
        string EvenStringLengthInput = "glory";
        string expected = "o";

        //Act
        string actual = MiddleCharacters.GetMiddleChars(EvenStringLengthInput);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
