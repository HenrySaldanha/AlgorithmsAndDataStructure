using Problems.String;
using System.Linq;
using Xunit;

namespace Problems.Test.String
{
    public class GenerateParenthesesTests
    {
        [Theory]
        [InlineData(1, new[] { "()" })]
        [InlineData(2, new[] { "(())", "()()" })]
        [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(int n, string[] responseExpected)
        {
            //Arrange
            var solution = new GenerateParentheses();

            //Act
            var response = solution.SolutionA(n);

            //Assert
            Assert.True(responseExpected.Except(response).Count() == 0);
        }
    }
}
