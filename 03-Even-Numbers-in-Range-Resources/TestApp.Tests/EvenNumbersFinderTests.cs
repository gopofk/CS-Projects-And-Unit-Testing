using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class EvenNumbersFinderTests
    {
        [Test]
        public void Test_FindEvenNumbers_StartGreaterThanEnd_ReturnsErrorMessage()
        {
            //Arrange
            int a = 10;
            int b = 1;
            string expected = "Start number should not be greater than end number.";

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_NoEvenNumbersInRange_ReturnsEmptyString()
        {
            //Arrange
            int a = 23;
            int b = 23;
            string expected = string.Empty;

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_SingleEvenNumberInRange_ReturnsThatNumber()
        {
            //Arrange
            int a = 21;
            int b = 23;
            string expected = "22";

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_MultipleEvenNumbersInRange_ReturnsEvenNumbers()
        {
            //Arrange
            int a = 1;
            int b = 5;
            string expected = "2 4";

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_FindEvenNumbers_ZeroInRange_ReturnsZero()
        {
            //Arrange
            int a = 0;
            int b = 0;
            string expected = "0";

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
