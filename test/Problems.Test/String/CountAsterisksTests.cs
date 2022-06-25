namespace Problems.Test.String;

public class CountAsterisksTests
{
    [Theory]
    [InlineData("iamprogrammer", 0)]
    [InlineData("yo|uar|e**|b|e***au|tifu|l", 5)]
    [InlineData("l|*e*et|c**o|*de|", 2)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string input, int responseExpected)
    {
        //Arrange
        var solution = new CountAsterisks();

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}