using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new();
        int threshold = 5;

        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new() { 9, 17, 22, 7};
        int threshold = 5;

        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 3, 10, 6, 5 };
        int threshold = 10;

        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        //Assert
        CollectionAssert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new() { 9, 7, 14, 4, 0, 8 };
        int threshold = 7;
        List<int> expected = new() { 7, 4, 0 };

        //Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        //Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
