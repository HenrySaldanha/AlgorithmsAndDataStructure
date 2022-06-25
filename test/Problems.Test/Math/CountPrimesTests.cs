namespace Problems.Test.Math;

public class CountPrimesTests
{
    [Theory]
    [InlineData(10, 4)]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int n, int answer)
    {
        //Arrange
        var solution = new CountPrimes();

        //Act
        var response = solution.Solution(n);

        //Assert
        Assert.Equal(answer, response);
    }
}