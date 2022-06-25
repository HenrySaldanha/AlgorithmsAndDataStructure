namespace Problems.Test.String;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string input, bool responseExpected)
    {
        //Arrange
        var solution = new ValidPalindrome();

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}