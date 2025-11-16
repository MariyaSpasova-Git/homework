using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "told";
        string input = "The lady told me to wait.";
        string expected = "The lady me to wait.";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "This";
        string input = "This time it was really difficult.";
        string expected = "time it was really difficult.";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "do";
        string input = "I didn't know what to do!";
        string expected = "I didn't know what to !";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "duck";
        string input = "The first duck looked at the second duck and laughed.";
        string expected = "The first looked at the second and laughed.";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

    //// Bonus test
    //[Test]
    //public void Test_RemoveOccurrences_RemovesAllOccurrencesCaseInsensitive()
    //{
    //    // Arrange
    //    string toRemove = "the";
    //    string input = "The magic mirror shoed him the truth.";
    //    string expected = "magic mirror shoed him truth.";

    //    // Act
    //    string result = Substring.RemoveOccurrences(toRemove, input);

    //    // Assert
    //    Assert.That(result, Is.EqualTo(expected));
    //}

    ////Bonus test
    //[Test]
    //public void Test_ReturnOriginalText_NoOccurrences()
    //{
    //    // Arrange
    //    string toRemove = "bear";
    //    string input = "The wolf went into the barn.";
        
    //    // Act
    //    string result = Substring.RemoveOccurrences(toRemove, input);

    //    // Assert
    //    Assert.That(result, Is.EqualTo(input));
    //}

    ////Bonus test
    //[Test]
    //public void Test_ReturnOriginalText_EmptyToRemove()
    //{
    //    // Arrange
    //    string toRemove = string.Empty;
    //    string input = "Help me clean this up!";

    //    // Act
    //    string result = Substring.RemoveOccurrences(toRemove, input);

    //    // Assert
    //    Assert.That(result, Is.EqualTo(input));
    //}

//    //Bonus test
//    [Test]
//    public void Test_ReturnEmptyString_EmptyInput()
//    {
//        // Arrange
//        string toRemove = "cat";
//        string input = string.Empty;

//        // Act
//        string result = Substring.RemoveOccurrences(toRemove, input);

//        // Assert
//        Assert.That(result, Is.Empty);
//    }

//    //Bonus test
//    [Test]
//    public void Test_ReturnOccurences_ToRemoveHasMultipleWords()
//    {
//        // Arrange
//        string toRemove = "is always";
//        string input = "The sun is always there";
//        string expected = "The sun there";

//        // Act
//        string result = Substring.RemoveOccurrences(toRemove, input);

//        // Assert
//        Assert.That(result, Is.EqualTo(expected));
//    }

//    //Bonus test
//    [Test]
//    public void Test_ReturnOccurences_ToRemoveIsSingleChar()
//    {
//        // Arrange
//        string toRemove = "o";
//        string input = "Come on, don't be shy. Lets go!";
//        string expected = "Cme n, dn't be shy. Lets g!";

//        // Act
//        string result = Substring.RemoveOccurrences(toRemove, input);

//        // Assert
//        Assert.That(result, Is.EqualTo(expected));
//    }
//}
