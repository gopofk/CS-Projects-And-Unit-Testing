namespace _01.TestSummator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            int[] nums = new[] { 5, 5 };

            //Act
            int sum = Sum(nums);


            //Assert
            Assert.AreEqual(10, sum);
        }
    }
}