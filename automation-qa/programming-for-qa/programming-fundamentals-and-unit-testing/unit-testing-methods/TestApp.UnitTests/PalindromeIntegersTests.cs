using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        //Arrange
        List<int> emptyList = new List<int> { };
        PalindromeIntegers instantion = new PalindromeIntegers();

        //Act
        List<int> actual = instantion.FindPalindromes(emptyList);

        //Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        //Arrange
        List<int> noPalindromesList = new List<int> { 23, 5678, 893 };
        PalindromeIntegers instantion = new PalindromeIntegers();

        //Act
        List<int> actual = instantion.FindPalindromes(noPalindromesList);

        //Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> onlySingleDigitsList = new List<int> { 5, 0, 7, 2 };
        PalindromeIntegers instantion = new PalindromeIntegers();

        //Act
        List<int> actual = instantion.FindPalindromes(onlySingleDigitsList);

        //Assert
        CollectionAssert.AreEqual(onlySingleDigitsList, actual);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> onlyPalindromesList = new List<int> { 151, 3443, 2678762 };
        PalindromeIntegers instantion = new PalindromeIntegers();

        //Act
        List<int> actual = instantion.FindPalindromes(onlyPalindromesList);

        //Assert
        CollectionAssert.AreEqual(onlyPalindromesList, actual);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        //Arrange
        List<int> mixedCaseList = new List<int> { 1, 272, 56, 90809, 123 };
        List<int> expected = new List<int> { 1, 272, 90809 };
        PalindromeIntegers instantion = new PalindromeIntegers();

        //Act
        List<int> actual = instantion.FindPalindromes(mixedCaseList);

        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
