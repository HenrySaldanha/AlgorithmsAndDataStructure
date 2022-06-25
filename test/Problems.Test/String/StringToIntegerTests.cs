namespace Problems.Test.String;

public class StringToIntegerTests
{
    [Theory]
    [InlineData("   -42", -42)]
    [InlineData("+-12", 0)]
    [InlineData("12345", 12345)]
    [InlineData("12345123123123", int.MaxValue)]
    [InlineData("-12345123123123", int.MinValue)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string array, int responseExpected)
    {
        //Arrange
        var solution = new StringToInteger();

        //Act
        var response = solution.Solution(array);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}