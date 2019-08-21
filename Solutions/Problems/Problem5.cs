namespace Solutions
{
    public class Problem5 : IProblem
    {
        public ulong Run(ulong targetNumber)
        {
            for (ulong i = 1; i > 0; i++)
            {
                for (ulong j = 1; j <= targetNumber; j++)
                {
                    if (i % j != 0)
                        break;

                    if (j == targetNumber)
                        return i;
                }
            }

            return 0;
        }
    }
}