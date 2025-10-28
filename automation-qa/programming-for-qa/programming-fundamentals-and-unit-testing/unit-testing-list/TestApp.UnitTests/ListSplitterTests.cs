using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        //Arrange
        List<int> input = new();

        //Act
        (List<int> evensResult, List<int> oddsResult) = ListSplitter.SplitEvenAndOdd(input);

        //Assert
        Assert.That(evensResult, Is.Empty);
        Assert.That(oddsResult, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        //Arrange
        List<int> input = new() { 18, 10, 2};

        //Act
        (List<int> evensResult, List<int> oddsResult) = ListSplitter.SplitEvenAndOdd(input);

        //Assert
        Assert.That(oddsResult, Is.Empty);
        Assert.That(evensResult, Is.EqualTo(input));
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        //Arrange
        List<int> input = new() { 99, 33, 15 };

        //Act
        (List<int> evensResult, List<int> oddsResult) = ListSplitter.SplitEvenAndOdd(input);

        //Assert
        Assert.That(evensResult, Is.Empty);
        Assert.That(oddsResult, Is.EqualTo(input));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        //Arrange
        List<int> input = new() { 28, 16, 9, 17, 4, 3 };
        List<int> evensExpected = new() { 28, 16, 4 };
        List<int> oddsExpected = new() { 9, 17, 3 };

        //Act
        (List<int> evensResult, List<int> oddsResult) = ListSplitter.SplitEvenAndOdd(input);

        //Assert
        Assert.That(evensResult, Is.EqualTo(evensExpected));
        Assert.That(oddsResult, Is.EqualTo(oddsExpected));
    }
}
