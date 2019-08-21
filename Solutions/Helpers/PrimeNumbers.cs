using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Helpers
{
    public class PrimeNumbers
    {
        private readonly List<ulong> _primeNumbers = new List<ulong> {2, 3};

        public IEnumerable<ulong> GetPrimeNumbersUpToN(ulong numberLimit)
        {
            if (_primeNumbers.Last() >= numberLimit)
                return _primeNumbers.Where(x => x <= numberLimit);

            while (_primeNumbers.Last() < numberLimit)
            {
                AddNextPrimeNumberToList();
            }

            if (_primeNumbers.Last() > numberLimit)
                _primeNumbers.RemoveAt(_primeNumbers.Count - 1);
            
            return _primeNumbers;
        }

        public ulong GetTheNthPrimeNumber(int n)
        {
            var primes = GetNPrimeNumbers(n);

            return primes.ElementAt(n - 1);
        }

        public IEnumerable<ulong> GetNPrimeNumbers(int howManyPrimes)
        {
            while (_primeNumbers.Count < howManyPrimes)
            {
                AddNextPrimeNumberToList();
            }

            for (var i = 0; i < howManyPrimes; i++)
            {
                yield return _primeNumbers[i];
            }
        }

        public IEnumerable<ulong> GetPrimeFactors(ulong targetNumber)
        {
            var squareRoot = Math.Ceiling(Math.Sqrt(targetNumber));

            while (_primeNumbers.Last() < squareRoot)
            {
                AddNextPrimeNumberToList();
            }

            return _primeNumbers.Where(primeNumber => targetNumber % primeNumber == 0);
        }

        private void AddNextPrimeNumberToList()
        {
            var primeCandidate = _primeNumbers[_primeNumbers.Count - 1] + 2;

            do
            {
                var isPrime = primeCandidate.IsAPrimeNumber();

                if (isPrime)
                {
                    _primeNumbers.Add(primeCandidate);
                    return;
                }

                primeCandidate += 2;
            } while (true);
        }
    }
}