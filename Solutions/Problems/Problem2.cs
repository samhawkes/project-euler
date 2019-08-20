using System;
using System.Linq;
using Solutions.Helpers;

namespace Solutions
{
    public class Problem2 : IProblem
    {
        public int Run(int? targetNumber)
        {
            var fibonacci = new FibonacciNumbers();

            if (targetNumber == null)
                throw new ArgumentException("Please enter a target number.");
            
            var numbers = fibonacci.GetFibonacciNumbersUpToN((ulong) targetNumber);

            return (int) numbers.Sum(num => num % 2d == 0d ? num : 0d);
        }
    }
}