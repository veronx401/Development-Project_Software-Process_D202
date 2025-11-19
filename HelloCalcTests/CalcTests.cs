using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCalcApp
{
    public class CalcTests :IDisposable
    {
        private Calculator calc;
    public CalcTests()
        {
            calc = new Calculator();
        }

    [Fact]
        public void AddTwoIntegers()
        {
            // arrange
            //var calc = new Calculator();

            //act 
            var result = calc.Add(1, 2);

            //assert
            Assert.Equal(3, result);
        }


        [Fact]
        public void SubtractTwoIntegers()
        {
            //arrange
            //var calc = new Calculator();

            //act
            var result = calc.Subtract(3, 2);

            //assert
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 },6)]
        [InlineData(new int[] { 4, 5, 6 },15)]
        public void AddMultipleIntegers(int[] numbers, int expected)
        {
            // arrange
            //var calc = new Calculator();

            //act
            var result = calc.Add(numbers);

            //assert 
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] {5, 2, 1 },2)]
        [InlineData(new int[] { 10, 5,2},3)]
        public void SubtractMultipleIntegers(int[] numbers, int expected)
        {
            // arrange
            //var calc = new Calculator();

            //act
            var result = calc.Subtract(numbers);

            //assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void AddAndStoreInHistory()
        {
            //arrange
            //var calc = new Calculator();

            //act
            var result1 = calc.Add(1, 2, 3); // 6
            var result2 = calc.Add(4, 5, 6); // 15
            //assert
            Assert.Equal(2, calc.History.Count);
            Assert.Equal(result1, calc.History[0]);
            Assert.Equal(result2, calc.History[1]);
        }


        [Fact]
        public void StoreInHistory()
        {
            //arrange
            //var calc = new Calculator(); (because we doing it in constructor)

            //act
            var result1 = calc.Add(1, 2, 3);
            var result2 = calc.Add(4, 5, 6);

            //assert again
            Assert.Equal(2, calc.History.Count);
            Assert.Equal(result1, calc.History[0]);
            Assert.Equal(result2, calc.History[1]);
        }


        [Theory]
        [InlineData("2+3", 5)]
        [InlineData("5-3", 2)]
        [InlineData("4+6-2", 8)]
        [InlineData("10+20-5+8", 33)]
        public void ParseEquationString(string equation, int expected)
        {
            //arrange

            //act
            var result = calc.Calculate(equation);

            //assert
            Assert.Equal(expected, result);
        }
        public void Dispose()
        {

        }
    }

}
