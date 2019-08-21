using Xunit;

namespace Solutions.Tests.Problems
{
    public class Problem2Tests
    {
        private IProblem _problem;

        public Problem2Tests()
        {
            _problem = new Problem2();
        }

        [Theory]
        [InlineData(4000000, 4613732)]
        public void Problem2(ulong targetNumber, ulong expectedOutcome)
        {
            Assert.True(_problem.Run(targetNumber).Equals(expectedOutcome));
        }
    }
}