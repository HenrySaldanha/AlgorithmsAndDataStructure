using Problems.String;

namespace Problems.Test.String
{
    public class FirstUniqueCharacterInAStringTests
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        [InlineData("aabb", -1)]
        public void Solution_ValidInput_MustReturnCorrectAnswer(string input, int responseExpected)
        {
            //Arrange
            var solution = new FirstUniqueCharacterInAString();

            //Act
            var response = solution.Solution(input);

            //Assert
            Assert.Equal(responseExpected, response);
        }
    }
}
