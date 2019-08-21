using System;
using System.Linq;
using Solutions.Helpers;

namespace Solutions
{
    public class Problem2 : IProblem
    {
        public ulong Run(ulong targetNumber)
        {
            var fibonacci = new FibonacciNumbers();
            
            var numbers = fibonacci.GetFibonacciNumbersUpToN(targetNumber);

            return (ulong) numbers.Sum(num => num % 2d == 0d ? num : 0d);
        }
    }
}