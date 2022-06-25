namespace Problems.Test.String;

public class LargestThreeSameDigitNumberInStringTests
{
    [Theory]
    [InlineData("6777133339", "777")]
    [InlineData("2300019", "000")]
    [InlineData("42352338", "")]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string input, string responseExpected)
    {
        //Arrange
        var solution = new LargestThreeSameDigitNumberInString();

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}