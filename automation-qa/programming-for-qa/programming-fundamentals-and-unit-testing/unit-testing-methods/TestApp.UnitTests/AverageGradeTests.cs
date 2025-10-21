using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestApp;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        //Arrange
        List <double> invalidInputBelowLimit = new List<double> { 1, 2, 2.5 };
        string expected = "Incorrect grades";

        //Act
        string actual = AverageGrade.GetGradeDefinition(invalidInputBelowLimit);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        //Arrange
        List<double> invalidInputAboveLimit = new List<double> { 6, 8.5, 10.7, 9 };
        string expected = "Incorrect grades";

        //Act
        string actual = AverageGrade.GetGradeDefinition(invalidInputAboveLimit);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        //Arrange
        List<double> validInputFail = new List<double> { 2.5, 3, 2 };
        string expected = "Fail";

        //Act
        string actual = AverageGrade.GetGradeDefinition(validInputFail);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        //Arrange
        List<double> validInputPoor = new List<double> { 3, 3.75, 3.20 };
        string expected = "Poor";

        //Act
        string actual = AverageGrade.GetGradeDefinition(validInputPoor);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        //Arrange
        List<double> validInputGood = new List<double> { 3.5, 5 };
        string expected = "Good";

        //Act
        string actual = AverageGrade.GetGradeDefinition(validInputGood);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        //Arrange
        List<double> validInputVeryGood = new List<double> { 4.25, 6, 5.30 };
        string expected = "Very good";

        //Act
        string actual = AverageGrade.GetGradeDefinition(validInputVeryGood);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        //Arrange
        List<double> validInputExcellent = new List<double> { 5.75, 6, 5.50 };
        string expected = "Excellent";

        //Act
        string actual = AverageGrade.GetGradeDefinition(validInputExcellent);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
