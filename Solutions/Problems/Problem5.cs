namespace Solutions
{
    public class Problem5 : IProblem
    {
        public int Run(ulong targetNumber)
        {
            for (var i = 1; i > 0; i++)
            {
                for (var j = 1; j <= (int)targetNumber; j++)
                {
                    if (i % j != 0)
                        break;

                    if (j == (int)targetNumber)
                        return i;
                }
            }

            return 0;
        }
    }
}