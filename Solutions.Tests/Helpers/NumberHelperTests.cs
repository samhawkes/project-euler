using Solutions.Helpers;
using Xunit;

namespace Solutions.Tests.Helpers
{
    public class NumberHelperTests
    {
        
        [Theory]
        [InlineData(2)]
        [InlineData(8)]
        [InlineData(21)]
        [InlineData(55)]
        [InlineData(1836311903)]
        [InlineData(17711)]
        [InlineData(1597)]
        [InlineData(28657)]
        public void IsFibonacci(ulong candidate)
        {
            Assert.True(candidate.IsAFibonacciNumber());
        }
        
        [Theory]
        [InlineData(4)]
        [InlineData(9)]
        [InlineData(22)]
        [InlineData(80)]
        [InlineData(1234567889)]
        public void IsNotFibonacci(ulong candidate)
        {
            Assert.False(candidate.IsAFibonacciNumber());
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void IsPrime(ulong candidate)
        {
            Assert.True(candidate.IsAPrimeNumber());
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(15)]
        public void IsNotPrime(ulong candidate)
        {
            Assert.False(candidate.IsAPrimeNumber());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(9)]
        [InlineData(822649)]
        public void IsAPerfectSquare(ulong candidate)
        {
            Assert.True(candidate.IsAPerfectSquare());
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(8)]
        [InlineData(12345678)]
        public void IsNotAPerfectSquare(ulong candidate)
        {
            Assert.False(candidate.IsAPerfectSquare());
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(33, 56, 65)]
        public void IsAPythagoreanTriplet(ulong a, ulong b, ulong c)
        {
            Assert.True(NumberHelpers.IsAPythagoreanTriplet(a, b, c));
        }
        
        [Theory]
        [InlineData(2, 4, 5)]
        [InlineData(32, 55, 66)]
        public void IsNotAPythagoreanTriplet(ulong a, ulong b, ulong c)
        {
            Assert.False(NumberHelpers.IsAPythagoreanTriplet(a, b, c));
        }S
    }
}