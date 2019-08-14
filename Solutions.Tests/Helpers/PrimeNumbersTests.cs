using System.Linq;
using Solutions.Helpers;
using Xunit;

namespace Solutions.Tests.Helpers
{
    public class PrimeNumbersTests
    {
        private PrimeNumbers _primeNumbers;

        public PrimeNumbersTests()
        {
            _primeNumbers = new PrimeNumbers();
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void IsPrime(int candidate)
        {
            Assert.True(_primeNumbers.IsAPrimeNumber(candidate));
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(15)]
        public void IsNotPrime(int candidate)
        {
            Assert.False(_primeNumbers.IsAPrimeNumber(candidate));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(4, 7)]
        [InlineData(6, 13)]
        [InlineData(10, 29)]
        [InlineData(20, 71)]
        [InlineData(10001, 104743)]
        public void NthPrimeNumber(int n, int expectedValue)
        {
            var nthPrime = _primeNumbers.GetTheNthPrimeNumber(n);
            
            Assert.True(nthPrime.Equals(expectedValue));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10000)]
        public void GetNPrimeNumbers(int numberOfPrimes)
        {
            var primes = _primeNumbers.GetNPrimeNumbers(numberOfPrimes);
            
            Assert.True(primes.Count().Equals(numberOfPrimes));
        }

        [Theory]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(100, 97)]
        [InlineData(100005, 100003)]
        [InlineData(100003, 100003)]
        public void GetPrimeNumbersUpToN(int numberLimit, int expectedLastPrime)
        {
            var primes = _primeNumbers.GetPrimeNumbersUpToN(numberLimit);
            
            Assert.True(primes.Last().Equals(expectedLastPrime), $"Last Prime = {primes.Last()}. Expected Last = {expectedLastPrime}");
        }
    }
}