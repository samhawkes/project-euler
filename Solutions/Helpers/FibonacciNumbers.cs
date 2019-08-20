using System.Collections.Generic;
using System.Linq;

namespace Solutions.Helpers
{
    public class FibonacciNumbers
    {
        private readonly List<ulong> _fibonacciNumbers = new List<ulong> {1, 1};

        public IEnumerable<ulong> GetFibonacciNumbersUpToN(ulong n)
        {
            if (_fibonacciNumbers.Last() >= n)
                return _fibonacciNumbers.Where(x => x <= n);

            while (_fibonacciNumbers.Last() < n)
            {
                AddNextFibonacciNumberToList();
            }

            if (_fibonacciNumbers.Last() > n)
                _fibonacciNumbers.RemoveAt(_fibonacciNumbers.Count - 1);
            
            return _fibonacciNumbers;
        }

        public IEnumerable<ulong> GetNFibonacciNumbers(int n)
        {
            while (_fibonacciNumbers.Count < n)
            {
                AddNextFibonacciNumberToList();
            }

            for (var i = 0; i < n; i++)
            {
                yield return _fibonacciNumbers[i];
            }
        }
        
        public ulong GetTheNthFibonacciNumber(int n)
        {
            var fibonacciNumbers = GetNFibonacciNumbers(n);

            return fibonacciNumbers.ElementAt(n - 1);
        }
        
        private void AddNextFibonacciNumberToList()
        {
            var nextNumber = _fibonacciNumbers.Last() + _fibonacciNumbers.ElementAt(_fibonacciNumbers.Count - 2);
            
            _fibonacciNumbers.Add(nextNumber);
        }
    }
}