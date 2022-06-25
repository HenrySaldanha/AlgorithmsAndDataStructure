namespace Problems.Test.String;

public class FindTheDifferenceTests
{
    [Theory]
    [InlineData("aab", "aabc", 'c')]
    [InlineData("abcd", "dbcax", 'x')]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(string s, string t, char responseExpected)
    {
        //Arrange
        var solution = new FindTheDifference();

        //Act
        var response = solution.SolutionA(s, t);

        //Assert
        Assert.Equal(responseExpected, response);
    }

    [Theory]
    [InlineData("aab", "aabc", 'c')]
    [InlineData("abcd", "dbcax", 'x')]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(string s, string t, char responseExpected)
    {
        //Arrange
        var solution = new FindTheDifference();

        //Act
        var response = solution.SolutionB(s, t);

        //Assert
        Assert.Equal(responseExpected, response);
    }

    [Theory]
    [InlineData("aab", "aabc", 'c')]
    [InlineData("abcd", "dbcax", 'x')]
    public void SolutionC_ValidInput_MustReturnCorrectAnswer(string s, string t, char responseExpected)
    {
        //Arrange
        var solution = new FindTheDifference();

        //Act
        var response = solution.SolutionC(s, t);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}