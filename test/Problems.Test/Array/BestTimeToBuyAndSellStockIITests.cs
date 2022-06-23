using Problems.Array;

namespace Problems.Test.Array;

public class BestTimeToBuyAndSellStockIITests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] heights, int answer)
    {
        //Arrange
        var solution = new BestTimeToBuyAndSellStockII();

        //Act
        var response = solution.Solution(heights);

        //Assert
        Assert.Equal(answer, response);
    }
}