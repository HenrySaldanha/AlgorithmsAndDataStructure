using Problems.String;
using Xunit;

namespace Problems.Test.String
{
    public class ValidPalindromeTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(string input, bool responseExpected)
        {
            //Arrange
            var solution = new ValidPalindrome();

            //Act
            var response = solution.SolutionA(input);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
