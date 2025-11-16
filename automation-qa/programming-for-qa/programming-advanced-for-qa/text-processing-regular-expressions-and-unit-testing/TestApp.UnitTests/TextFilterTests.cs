using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
     [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "beans", "pepper" };
        string input = "The banana is sneaking out";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "tomato", "pepper" };
        string input = "The red tomato is better than the green pepper.";
        string expected = "The red ****** is better than the green ******.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[0];
        string input = "The joke was good!";
        
        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "better than", "agree with" };
        string input = "You're better than me and I totally agree with that.";
        string expected = "You're *********** me and I totally ********** that.";

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    ////Bonus test
    //[Test]
    //public void Test_Filter_WhenTextIsEmpty_ShouldReturnEmptyString()
    //{
    //    // Arrange
    //    string[] bannedWords = new string[] { "common", "mistake" };
    //    string input = string.Empty;
       
    //    // Act
    //    string result = TextFilter.Filter(bannedWords, input);

    //    // Assert
    //    Assert.That(result, Is.Empty);
    //}

    ////Bonus test
    //[Test]
    //public void Test_Filter_WhenSeveralInstancesOfWordRepeats_ShouldReplaceAllOccurences()
    //{
    //    // Arrange
    //    string[] bannedWords = new string[] { "your", "red" };
    //    string input = "your face became so red when you heard the news, but your eyes were clear.";
    //    string expected = "**** face became so *** when you heard the news, but **** eyes were clear.";

    //    // Act
    //    string result = TextFilter.Filter(bannedWords, input);

    //    // Assert
    //    Assert.That(result, Is.EqualTo(expected));
    //}
}
