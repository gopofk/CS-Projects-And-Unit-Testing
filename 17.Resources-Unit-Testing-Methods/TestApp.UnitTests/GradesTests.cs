using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(4.499, "Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(5.499, "Very Good")]
    [TestCase(5.50, "Excellent")]
    [TestCase(6, "Excellent")]
    [TestCase(5.99, "Excellent")]
    [TestCase(3, "Average")]
    [TestCase(4, "Good")]
    [TestCase(4.50, "Very Good")]
    [TestCase(5, "Very Good")]
    [TestCase(5.33, "Very Good")]
    [TestCase(5.51, "Excellent")]
    [TestCase(+6, "Invalid!")]
    [TestCase(5 + 6, "Invalid!")]
    [TestCase(5.80, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase(1, "Invalid!")]
    [TestCase(6.50, "Invalid!")]
    [TestCase(0, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
