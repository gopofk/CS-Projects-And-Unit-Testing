using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class ConsonantsCounterTests
    {
        [Test]
        public void Test_CountTotalConsonants_GetEmptyList_ReturnsZero()
        {
            //Arrange
            List<string> input = new List<string>();
            int expected = 0;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_CountTotalConsonants_GetListWithEmptyStringValues_ReturnsZero()
        {
            //Arrange
            List<string> input = new() { "", "", "", ""};
            int expected = 0;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_CountTotalConsonants_MultipleStrings_ReturnsConsonantsCount()
        {
            //Arrange
            List<string> input = new() {"hello", "goodbye", "ok", "see" };
            int expected = 9;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_CountTotalConsonants_GetStringsWithNoConsonants_ReturnsZero()
        {
            //Arrange
            List<string> input = new() { "eo", "ooe", "O", "ee" };
            int expected = 0;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_CountTotalConsonants_StringsWithMixedCaseConsonants_ReturnsConsonantsCount()
        {
            //Arrange
            List<string> input = new() { "Hello", "GoodBye", "OK", "See" };
            int expected = 9;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }

}

