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
        public void Problem1(ulong targetNumber, int expectedOutcome)
        {
            var ans = _problem.Run(targetNumber);
            Assert.True(ans.Equals(expectedOutcome), $"{ans}");
        }
    }
}