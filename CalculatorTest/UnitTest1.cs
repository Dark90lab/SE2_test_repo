using System;
using Xunit;
using Calculator;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        public void SumTwoNumbers(int x, int y,int expectedResult)
        {
            int result = NumberCalculator.sumNumbers(x, y);
            Assert.Equal(expectedResult, result );

        }
    }
}
