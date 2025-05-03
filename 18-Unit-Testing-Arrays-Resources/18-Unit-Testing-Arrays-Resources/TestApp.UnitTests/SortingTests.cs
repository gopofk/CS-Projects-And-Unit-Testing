using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] empty = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        //Act
        double[] actual = Sorting.ShallowAscendingSort(empty);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] empty = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        //Act
        double[] actual = Sorting.DeepAscendingSort(empty);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        //Arrange
        double[] arrayShallow = new double[] {4, 6, 2, 3};
        double[] expected = new double[] {2, 3, 4, 6};

        //Act
        double[] actual = Sorting.ShallowAscendingSort(arrayShallow);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        //Arrange
        double[] arrayDeep = new double[] { 4, 6, 2, 3 };
        double[] expected = new double[] { 2, 3, 4, 6 };

        //Act
        double[] actual = Sorting.DeepAscendingSort(arrayDeep);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
