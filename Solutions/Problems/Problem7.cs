using Solutions.Helpers;

namespace Solutions
{
    public class Problem7 : IProblem
    {
        public ulong Run(ulong targetNumber)
        {
            var primes = new PrimeNumbers();

            return primes.GetTheNthPrimeNumber((int) targetNumber);
        }
    }
}