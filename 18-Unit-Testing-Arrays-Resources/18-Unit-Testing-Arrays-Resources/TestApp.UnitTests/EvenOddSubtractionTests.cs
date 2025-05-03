using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNumbers = new int[] { 2, 4, 6 };
        int expected = 12;

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] evenNumbers = new int[] { 1, 3, 5 };
        int expected = -9;

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] evenNumbers = new int[] { 1, 3, 5, 2, 4, 6 };
        int expected = 12-9;

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
