namespace HelloCalcTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void MyFirstTest()
        {

        }

        [Fact]
        public void TestIfTrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void TwoPlusTwoEqualsFour()
        {
            int result = 2 + 2;
            Assert.Equal(4, result);
        }

        [Fact]
        public void TwoPlusTwoNotEqualsFive()
        {
            int result = 2 + 2;
            Assert.NotEqual(5, result);
        }


        [Fact]
        public void CanAddNumbers()
        {
            // Arrange
            int num1 = 2;
            int num2 = 3;

            //act
            int  result = num1 + num2;

            // assert
            Assert.Equal(5, result);
        }



        [Fact]
        public void CanCalculatedAverage()
        {
            // arrange
            int[] numbers = { 2, 3, 5, 7, 11 };

            // act
            double average = numbers.Average();

            //assert
            Assert.Equal(5.6, average, 1);
        }


        [Theory]
        [InlineData(3, 7, 10)]
        [InlineData(-3, -7, -10)]
        [InlineData(100, 200, 300)]
        public void CanAddNumbersParamaterized(int num1, int num2, int expected)
        {
            // arrange

            //act 
            int result = num1 + num2;

            //assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void TestFalse()
        {
            // arrange
            bool condition = false;

            // assert
            Assert.False(condition);
        }


        [Fact]
        public void TestNull()
        {
            //  arrange
            object obj = null;

            //assert
            Assert.Null(obj);
        }


        [Fact]
        public void TestNotNull()
        {

            //arrange
            object obj = new object();

            //assert
            Assert.NotNull(obj);
        }


        [Fact]
        public void TestContains()
        {
            //arrange
            List<int> collection = new List<int> { 42 };
            
            // assert
            Assert.Contains(42, collection);
        }


        [Fact]
        public void TestInRange()
        {
            //arrange
            int actual = 5;

            // assert
            Assert.InRange(actual, 0, 10);
        }

        [Fact]
        public void TestEmpty()
        {
            //arrange
            List<int> collection = new List<int>();

            //Assert
            Assert.Empty(collection);
        }

        [Fact]
        public void TestNotEmpty()
        {
            //arrange
            List<int> collection = new List<int> { 1 };

            //Assert
            Assert.NotEmpty(collection);
        }
    
    }
}