namespace Problems.Test.String;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(string s, int responseExpected)
    {
        //Arrange
        var solution = new LongestSubstringWithoutRepeatingCharacters();

        //Act
        var response = solution.SolutionA(s);

        //Assert
        Assert.Equal(responseExpected, response);
    }

    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(string s, int responseExpected)
    {
        //Arrange
        var solution = new LongestSubstringWithoutRepeatingCharacters();

        //Act
        var response = solution.SolutionB(s);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}