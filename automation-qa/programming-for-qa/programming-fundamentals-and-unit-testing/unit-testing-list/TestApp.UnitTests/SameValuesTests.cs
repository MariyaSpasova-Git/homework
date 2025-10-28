using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstListInput = new();
        List<int> secondListInput = new() { 3, 8, 21, 7 };
        
        //Act
        List<int> result = SameValues.FindSameValues(firstListInput, secondListInput);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        //Arrange
        List<int> firstListInput = new() { 4, 12, 5 };
        List<int> secondListInput = new();

        //Act
        List<int> result = SameValues.FindSameValues(firstListInput, secondListInput);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        List<int> firstListInput = new() { 1, 2, 3 };
        List<int> secondListInput = new() { 4, 5, 6 };

        //Act
        List<int> result = SameValues.FindSameValues(firstListInput, secondListInput);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        List<int> firstListInput = new() { 1, 3, 5, 7, 9 };
        List<int> secondListInput = new() { 1, 3, 5, 7, 9 };


        //Act
        List<int> result = SameValues.FindSameValues(firstListInput, secondListInput);

        //Assert
        CollectionAssert.AreEqual(firstListInput, result);
    }
}
