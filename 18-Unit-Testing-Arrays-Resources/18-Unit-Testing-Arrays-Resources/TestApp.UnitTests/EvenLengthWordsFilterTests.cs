using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        //Arrange
        string[] emptyString = Array.Empty<string>();
        string expected = string.Empty;
       
        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(emptyString);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        //Arrange
        string[] oneOdd = new string[] {"car"};
        string expected = string.Empty;
        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(oneOdd);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        //Arrange
        string[] oneOdd = new string[] { "car", "bar", "strings" };
        string expected = string.Empty;
        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(oneOdd);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        //Arrange
        string[] oneOdd = new string[] { "cars" };
        string expected = "cars";
        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(oneOdd);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        //Arrange
        string[] oneOdd = new string[] { "car", "ok", "sauce", "string" };
        string expected = "ok string";
        //Act
        string actual = EvenLengthWordsFilter.GetEvenWords(oneOdd);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

