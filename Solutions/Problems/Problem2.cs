using System;
using System.Linq;
using Solutions.Helpers;

namespace Solutions
{
    public class Problem2 : IProblem
    {
        public int Run(ulong targetNumber)
        {
            var fibonacci = new FibonacciNumbers();
            
            var numbers = fibonacci.GetFibonacciNumbersUpToN(targetNumber);

            return (int) numbers.Sum(num => num % 2d == 0d ? num : 0d);
        }
    }
}