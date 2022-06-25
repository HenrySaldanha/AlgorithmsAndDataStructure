namespace Problems.Test.String;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("[()]{}", true)]
    [InlineData("{]", false)]
    [InlineData("{]()", false)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string array, bool responseExpected)
    {
        //Arrange
        var solution = new ValidParentheses();

        //Act
        var response = solution.Solution(array);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}