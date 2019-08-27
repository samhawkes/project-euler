using Solutions.Problems;
using Xunit;

namespace Solutions.Tests.Problems
{
    public class Problem7Tests
    {
        private readonly IProblem _problem;

        public Problem7Tests()
        {
            _problem = new Problem7();
        }

        [Theory]
        [InlineData(10001, 104743)]
        public void Problem7(ulong targetNumber, ulong expectedOutcome)
        {
            Assert.True(_problem.Run(targetNumber).Equals(expectedOutcome));
        }
    }
}