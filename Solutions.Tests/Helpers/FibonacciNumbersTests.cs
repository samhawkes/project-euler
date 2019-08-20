using System.Linq;
using Solutions.Helpers;
using Xunit;

namespace Solutions.Tests.Helpers
{
    public class FibonacciNumbersTests
    {
        private readonly FibonacciNumbers _fibonacciNumbers;

        public FibonacciNumbersTests()
        {
            _fibonacciNumbers = new FibonacciNumbers();
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void GetNFibonacciNumbers(int n)
        {
            var fibonacciNumbers = _fibonacciNumbers.GetNFibonacciNumbers(n);
            
            Assert.True(fibonacciNumbers.Count().Equals(n));
        }

        [Theory]
        [InlineData(10, 55)]
        [InlineData(30, 832040)]
        public void GetTheNthFibonacciNumber(int n, ulong expectedValue)
        {
            Assert.Equal(_fibonacciNumbers.GetTheNthFibonacciNumber(n), expectedValue);
        }

        [Theory]
        [InlineData(60, 55)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 3)]
        [InlineData(832040, 832040)]
        [InlineData(832041, 832040)]
        [InlineData(832039, 514229)]
        public void GetFibonacciNumbersUpToN(ulong n, ulong expectedLastNumber)
        {
            var fibonacciNumbers = _fibonacciNumbers.GetFibonacciNumbersUpToN(n);
            
            Assert.Equal(fibonacciNumbers.Last(), expectedLastNumber);
        }
    }
}