using Xunit;

namespace Solutions.Tests.Problems
{
    public class Problem3Tests
    {
        private IProblem _problem;

        public Problem3Tests()
        {
            _problem = new Problem3();
        }

        [Theory]
        [InlineData(600851475143, 6857)]
        public void Problem1(ulong targetNumber, int expectedOutcome)
        {
            Assert.True(_problem.Run(targetNumber).Equals(expectedOutcome));
        }
    }
}