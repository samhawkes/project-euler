using System;
using System.Linq;
using Solutions.Helpers;

namespace Solutions
{
    public class Problem3 : IProblem
    {
        public int Run(ulong targetNumber)
        {
            var primes = new PrimeNumbers();

            var primeFactors = primes.GetPrimeFactors(targetNumber);

            return (int)primeFactors.Max();
        }
        
        
    }
}