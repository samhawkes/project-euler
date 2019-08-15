using System.Collections.Generic;
using System.Linq;

namespace Solutions.Helpers
{
    public class FibonacciNumbers
    {
        private readonly List<ulong> _fibonacciNumbers = new List<ulong> {1, 1};

        private void AddNextFibonacciNumberToList()
        {
            var nextNumber = _fibonacciNumbers.Last() + _fibonacciNumbers.ElementAt(_fibonacciNumbers.Count - 1);
            
            _fibonacciNumbers.Add(nextNumber);
        }
    }
}