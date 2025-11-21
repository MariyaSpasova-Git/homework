using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        _exceptions = new Exceptions();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "I am alive!";
        
        string expected = "!evila ma I";

        // Act
        string result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        
        string expectedMessage = "String cannot be null.";

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);

        try
        {
            _exceptions.ArgumentNullReverse(input);
        }
        catch (ArgumentNullException ex)
        {
            Assert.That(ex.Message, Does.Contain(expectedMessage));
        }
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 200;
        decimal discount = 10;
        
        decimal expected = 180;

        // Act
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100;
        decimal discount = -20;
        
        string expectedMessage = "Discount must be between 0 and 100.";

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);

        try
        {
            _exceptions.ArgumentCalculateDiscount(totalPrice, discount);
        }
        catch (ArgumentException ex)
        {
            Assert.That(ex.Message, Does.Contain(expectedMessage));
        }
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 50;
        decimal discount = 110;
        
        string expectedMessage = "Discount must be between 0 and 100.";

        // Act & Assert - old syntax
        ArgumentException ex = Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount));
        Assert.That(ex.Message, Does.Contain(expectedMessage));
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        int[] input = new int[] { 6, 8, 10, 3 };
        int index = 2;
        
        int expected = 10;

        // Act
        int result = _exceptions.IndexOutOfRangeGetElement(input, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = new int[] { 1, 9, 0, 5 };
        int index = -1;
        
        string expectedMessage = "Index is out of range.";

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());

        try 
        {
            _exceptions.IndexOutOfRangeGetElement(input, index);
        }
        catch (IndexOutOfRangeException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;
        
        string expectedMessage = "Index is out of range.";

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());

        try
        {
            _exceptions.IndexOutOfRangeGetElement(array, index);
        }
        catch (IndexOutOfRangeException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 8, 7, 3, 4 };
        int index = 10;
        
        string expectedMessage = "Index is out of range.";

        // Act & Assert - old syntax
        IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index));
        Assert.That(ex.Message, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool input = true;
        
        string expected = "User logged in.";

        //Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool input = false;
        
        string expectedMessage = "User must be logged in to perform this operation.";

        // Act & Assert
        Assert.That(() => _exceptions.InvalidOperationPerformSecureOperation(input), Throws.InvalidOperationException);

        try
        {
            _exceptions.InvalidOperationPerformSecureOperation(input);
        }
        catch(InvalidOperationException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "42";
        
        int expected = 42;

        // Act
        int result = _exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("twenty")]
    [TestCase("5.5")]
    [TestCase("3a")]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException(string input)
    {
        // Arrange
        string expectedMessage = "Input is not in the correct format for an integer.";

        // Act & Assert
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
        try
        {
            _exceptions.FormatExceptionParseInt(input);
        }
        catch (FormatException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("one", 1);
        input.Add("two", 2);
        input.Add("three", 3);

        string key = "two";
        
        int expected = 2;

        // Act
        int result = _exceptions.KeyNotFoundFindValueByKey(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Assert
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("one", 1);
        input.Add("two", 2);
        input.Add("three", 3);

        string key = "zero";

        string expectedMessage = "The specified key was not found in the dictionary.";

        // Act & Assert
        Assert.That(() => _exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());

        try
        {
            _exceptions.KeyNotFoundFindValueByKey(input, key);
        }
        catch (KeyNotFoundException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 3;
        int b = 6;
        
        int expected = 9;

        // Act
        int result = _exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = 2000000000;
        int b = 1000000000;

        string expectedMessage = "Arithmetic overflow occurred during addition.";

        // Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

        try
        {
            _exceptions.OverflowAddNumbers(a, b);
        }
        catch (OverflowException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        string expectedMessage = "Arithmetic overflow occurred during addition.";

        // Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());

        try
        {
            _exceptions.OverflowAddNumbers(a, b);
        }
        catch (OverflowException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int divident = 30;
        int divisor = 7;
        
        int expected = 4;

        // Act
        int result = _exceptions.DivideByZeroDivideNumbers(divident, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int divident = 3;
        int divisor = 0;

        string expectedMessage = "Division by zero is not allowed.";

        // Act & Assert
        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(divident, divisor), Throws.InstanceOf<DivideByZeroException>());

        try
        {
            _exceptions.DivideByZeroDivideNumbers(divident, divisor);
        }
        catch (DivideByZeroException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int index = 2;
        
        int expected = 15;

        // Act
        int result = _exceptions.SumCollectionElements(input, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] input = null;
        int index = 3;

        string expectedMessage = "Collection cannot be null";

        // Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.ArgumentNullException);

        try
        {
            _exceptions.SumCollectionElements(input, index);
        }
        catch (ArgumentNullException ex)
        {
            Assert.That(ex.Message, Does.Contain(expectedMessage));
        }
    }

    [TestCase(-1)]
    [TestCase(5)]
    [TestCase(10)]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException(int index)
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };

        string expectedMessage = "Index has to be within bounds.";

        // Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.InstanceOf<IndexOutOfRangeException>());

        try
        {
            _exceptions.SumCollectionElements(input, index);
        }
        catch (IndexOutOfRangeException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "2");
        input.Add("three", "3");

        string key = "three";
        
        int expected = 3;

        // Act
        int result = _exceptions.GetElementAsNumber(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "2");
        input.Add("three", "3");

        string key = "four";
        
        string expectedMessage = "Key not found in the dictionary.";

        // Act & Assert - old syntax
        var ex = Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(input, key));
        Assert.AreEqual(expectedMessage, ex.Message);
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "2");
        input.Add("three", "3.0");

        string key = "three";
        
        string expectedMessage = "Can't parse string.";

        // Act & Assert
        var ex = Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(input, key));
        Assert.AreEqual(expectedMessage, ex.Message);
    }
}
