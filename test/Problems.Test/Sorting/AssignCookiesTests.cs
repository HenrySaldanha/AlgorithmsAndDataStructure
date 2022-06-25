namespace Problems.Test.Sorting;

public class AssignCookiesTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 1 }, 1)]
    [InlineData(new[] { 1, 2 }, new[] { 1, 2, 3 }, 2)]
    [InlineData(new[] { 10, 9, 8, 7 }, new[] { 5, 6, 7, 8 }, 2)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] g, int[] s, int expectedResponse)
    {
        //Arrange
        var solution = new AssignCookies();

        //Act
        var response = solution.Solution(g, s);

        //Assert
        Assert.Equal(response, expectedResponse);
    }
}