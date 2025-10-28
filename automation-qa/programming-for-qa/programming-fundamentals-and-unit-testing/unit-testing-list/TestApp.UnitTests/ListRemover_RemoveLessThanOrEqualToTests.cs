using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new();
        int threshold = 9;

        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new() { 9, 13, 5, 18 };
        int threshold = 19;

        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 5, 13, 2 };
        int threshold = 1;

        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        //Assert
        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        // Arrange
        List<int> input = new() { 9, 7, 14, 4, 0, 8 };
        int threshold = 7;
        List<int> expected = new() { 9, 14, 8 };

        //Act
        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, threshold);

        //Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
