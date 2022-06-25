namespace Problems.Test.String;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("XIV", 14)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string array, int responseExpected)
    {
        //Arrange
        var solution = new RomanToInteger();

        //Act
        var response = solution.Solution(array);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}