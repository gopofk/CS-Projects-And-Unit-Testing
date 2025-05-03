using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        string expected = string.Empty;

        // Act
        string actual = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] inputOneElement = new int[] { 42 };
        string expected = "42";

        // Act

        string result = Reverse.ReverseArray(inputOneElement);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        //Arrange
        int[] inputMultipleElements = new int[] { -10, 20, 30 };
        string expected = "30 20 -10";

        // Act
        string result = Reverse.ReverseArray(inputMultipleElements);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}