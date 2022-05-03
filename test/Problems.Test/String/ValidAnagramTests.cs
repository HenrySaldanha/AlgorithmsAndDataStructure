using Problems.String;
using Xunit;

namespace Problems.Test.String
{
    public class ValidAnagramTests
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("nagaram", "anagram", true)]
        [InlineData("rat", "car", false)]
        [InlineData("car", "rat", false)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(string a, string b, bool responseExpected)
        {
            //Arrange
            var solution = new ValidAnagram();

            //Act
            var response = solution.SolutionA(a, b);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
