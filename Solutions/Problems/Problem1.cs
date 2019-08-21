using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public class Problem1 : IProblem
    {
        public int Run(ulong targetNumber)
        {
            var multiples = new List<int>();
            
            for (var i = 0; i < (int)targetNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiples.Add(i);
            }

            return multiples.Sum();
        }
    }
}