using Problems.Array;

namespace Problems.Test.Array;

public class ContainerWithMostWaterTests
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    [InlineData(new[] { 1, 1, 2, 3, 4 }, 4)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] heights, int answer)
    {
        //Arrange
        var solution = new ContainerWithMostWater();

        //Act
        var response = solution.Solution(heights);

        //Assert
        Assert.Equal(answer, response);
    }
}