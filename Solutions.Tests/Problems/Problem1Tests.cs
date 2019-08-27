using Solutions.Problems;
using Xunit;

namespace Solutions.Tests.Problems
{
    public class Problem1Tests
    {
        private readonly IProblem _problem;

        public Problem1Tests()
        {
            _problem = new Problem1();
        }
        
        
        [Theory]
        [InlineData(10, 23)]
        public void Problem1(ulong targetNumber, ulong expectedOutcome)
        {
            Assert.True(_problem.Run(targetNumber).Equals(expectedOutcome));
        }
    }
}