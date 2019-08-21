using System;
using System.Linq;
using Solutions.Helpers;

namespace Solutions
{
    public class Problem3 : IProblem
    {
        public ulong Run(ulong targetNumber)
        {
            var primes = new PrimeNumbers();

            var primeFactors = primes.GetPrimeFactors(targetNumber);

            return primeFactors.Max();
        }
        
        
    }
}