using System.Linq;
using Solutions.Helpers;

namespace Solutions.Problems
{
    public class Problem2 : IProblem
    {
        public ulong Run(ulong targetNumber)
        {
            var fibonacci = new FibonacciNumbers();
            
            var numbers = fibonacci.GetFibonacciNumbersUpToN(targetNumber);

            return (ulong) numbers.Sum(num => num % 2 == 0 ? num : 0d);
        }
    }
}