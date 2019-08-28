using System.Linq;
using Solutions.Helpers;
using Xunit;

namespace Solutions.Tests.Helpers
{
    public class PrimeNumbersTests
    {
        private readonly PrimeNumbers _primeNumbers;

        public PrimeNumbersTests()
        {
            _primeNumbers = new PrimeNumbers();
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(4, 7)]
        [InlineData(6, 13)]
        [InlineData(10, 29)]
        [InlineData(20, 71)]
        [InlineData(10001, 104743)]
        public void NthPrimeNumber(int n, ulong expectedValue)
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
        [InlineData(3, 3)]
        [InlineData(2, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(100, 97)]
        [InlineData(100005, 100003)]
        [InlineData(100003, 100003)]
        public void GetPrimeNumbersUpToN(ulong numberLimit, ulong expectedLastPrime)
        {
            var primes = _primeNumbers.GetPrimeNumbersUpToN(numberLimit);

            Assert.True(primes.Last().Equals(expectedLastPrime));
        }

        [Theory]
        [InlineData(13195, new ulong[] {5, 7, 13, 29})]
        public void GetPrimeFactors(ulong targetNumber, ulong[] expectedPrimeFactors)
        {
            Assert.Equal(_primeNumbers.GetPrimeFactors(targetNumber), expectedPrimeFactors);
        }
        
    }
}