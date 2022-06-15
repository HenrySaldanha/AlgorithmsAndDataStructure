using Problems.String;
using Xunit;

namespace Problems.Test.String
{
    public class LengthOfLastWordTests
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void Solution_ValidInput_MustReturnCorrectAnswer(string array, int responseExpected)
        {
            //Arrange
            var solution = new LengthOfLastWord();

            //Act
            var response = solution.Solution(array);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
