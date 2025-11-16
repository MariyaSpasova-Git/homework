using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [TestCase("The exibition was on 31.Dec.2022", "Day: 31, Month: Dec, Year: 2022")]
    [TestCase("The was started on 09/September/1967", "Day: 09, Month: September, Year: 1967")]
    [TestCase("The record dated 29-Aug-2022 was valid", "Day: 29, Month: Aug, Year: 2022")]

    [Test]
    public void Test_Match_CheckValidDatesWithAllSeparators_ReturnsExpectedResult(string input, string expected)
    {
        // Arrange

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "He thought he was born on 23/June/1981, but only his mother knew that the real date was 24/June/1981.";
        string expected = "Day: 23, Month: June, Year: 1981";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;
        string expectedErrorMessage = "Input cannot be null!";

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
        Assert.That(ex.Message, Is.EqualTo(expectedErrorMessage));
    }

    [TestCase("The gathering will happen on 10/JANUARY/2026")]
    [TestCase("Missed call on 30-feb-2025")]
    [TestCase("On 17.jUl.2016 I heard the news")]
       public void Test_Match_InvalidMonthCase_ReturnsEmptyString(string input)
    {
        // Arrange

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [TestCase("That happened on 10-March,2024")]
    [TestCase("John marked the date 31 February 2019 in his notebook.")]
    [TestCase("The school opens on 1-Sep-2027")]
    [TestCase("The reply was received on the 13th of September, 2022")]
    [TestCase("They found the gold on 21-10-2011")]
    [TestCase("The date 30:April:2000 was written there")]
    [TestCase("They told me they would call me again on 01 - January - 2026")]
    public void Test_Match_InvalidDateFormat_ReturnsEmptyString(string input)
    {
        // Arrange

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
