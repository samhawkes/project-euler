using Xunit;

namespace Solutions.Tests.Problems
{
    public class Problem5Tests
    {
        private IProblem _problem;

        public Problem5Tests()
        {
            _problem = new Problem5();
        }

        [Theory]
        [InlineData(10, 2520)]
        [InlineData(20, 232792560)]
        public void Problem5(ulong targetNumber, ulong expectedOutcome)
        {
            Assert.True(_problem.Run(targetNumber).Equals(expectedOutcome));
        }
    }
}