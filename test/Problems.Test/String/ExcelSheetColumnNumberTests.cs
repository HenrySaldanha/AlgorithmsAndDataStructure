namespace Problems.Test.String;

public class ExcelSheetColumnNumberTests
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string input, int responseExpected)
    {
        //Arrange
        var solution = new ExcelSheetColumnNumber();

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}