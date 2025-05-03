using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] oneElement = { 1 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(oneElement);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        //Arrange
        int[] oneElement = { 6 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(oneElement);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        //Arrange
        int[] noPrimeNums = { 4, 8, 12 };
        int[] expected = Array.Empty<int>();

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(noPrimeNums);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        //Arrange
        int[] onePrimeNum = { 2, 4, 8, 12 };
        int[] expected = { 2 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(onePrimeNum);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        //Arrange
        int[] onePrimeNum = { 2, 3, 5, 12, 15, 16 };
        int[] expected = { 2, 3, 5 };

        //Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(onePrimeNum);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
