using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [TestCase("5.5")]
    [TestCase("5a")]
    [TestCase("pet")]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage(string input)
    {
        //Arrange
        string expected = "The input is not an integer!";

        //Act
        string actual = SignOfIntegerNumbers.CheckSign(input);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        //Arrange
        string zeroInput = "0";
        string expected = $"The number {zeroInput} is zero.";

        //Act
        string actual = SignOfIntegerNumbers.CheckSign(zeroInput);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        //Arrange
        string negativeInteger = "-10";
        string expected = $"The number {negativeInteger} is negative.";

        //Act
        string actual = SignOfIntegerNumbers.CheckSign(negativeInteger);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        //Arrange
        string positiveInteger = "3";
        string expected = $"The number {positiveInteger} is positive.";

        //Act
        string actual = SignOfIntegerNumbers.CheckSign(positiveInteger);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}
