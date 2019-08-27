using System.Linq;
using Solutions.Helpers;

namespace Solutions.Problems
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