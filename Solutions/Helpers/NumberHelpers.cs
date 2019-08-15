using System;

namespace Solutions.Helpers
{
    public static class NumberHelpers
    {
        public static bool IsAPrimeNumber(this ulong candidate)
        {
            if (candidate < 2)
                return false;
            
            for (uint divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                    return false;
            }

            return true;
        }

        public static bool IsAFibonacciNumber(this ulong candidate)
        {
            var n = candidate * candidate * 5;

            return IsAPerfectSquare(n + 4) || IsAPerfectSquare(n - 4);
        }

        public static bool IsAPerfectSquare(this ulong candidate)
        {
            var squareRoot = (ulong) Math.Sqrt(candidate);

            return squareRoot * squareRoot == candidate;
        }
    }
}