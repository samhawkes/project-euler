using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Helpers
{
    public class PrimeNumbers
    {
        private readonly List<int> _primeNumbers = new List<int> {2, 3};

        public IEnumerable<int> GetPrimeNumbersUpToN(int numberLimit)
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

        public int GetTheNthPrimeNumber(int n)
        {
            var primes = GetNPrimeNumbers(n);

            return primes.ElementAt(n - 1);
        }

        public IEnumerable<int> GetNPrimeNumbers(int howManyPrimes)
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
        
        public bool IsAPrimeNumber(int candidate)
        {
            if (candidate < 2)
                return false;
            
            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                    return false;
            }

            return true;
        }

        private void AddNextPrimeNumberToList()
        {
            var primeCandidate = _primeNumbers[_primeNumbers.Count - 1] + 2;

            do
            {
                var isPrime = IsAPrimeNumber(primeCandidate);

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