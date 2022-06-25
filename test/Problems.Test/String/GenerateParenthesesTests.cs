namespace Problems.Test.String;

public class GenerateParenthesesTests
{
    [Theory]
    [InlineData(1, new[] { "()" })]
    [InlineData(2, new[] { "(())", "()()" })]
    [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int n, string[] responseExpected)
    {
        //Arrange
        var solution = new GenerateParentheses();

        //Act
        var response = solution.Solution(n);

        //Assert
        Assert.Empty(responseExpected.Except(response));
    }
}