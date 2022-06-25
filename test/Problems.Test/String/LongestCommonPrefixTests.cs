namespace Problems.Test.String;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string[] input, string responseExpected)
    {
        //Arrange
        var solution = new LongestCommonPrefix();

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, response);
    }

    [Fact]
    public void Solution_InvalidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new LongestCommonPrefix();

        //Act
        var response = solution.Solution(System.Array.Empty<string>());

        //Assert
        Assert.Equal("", response);
    }
}