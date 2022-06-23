using Problems.Array;

namespace Problems.Test.Array;

public class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] array, int target, int answer)
    {
        //Arrange
        var solution = new SearchInsertPosition();

        //Act
        var response = solution.Solution(array, target);

        //Assert
        Assert.Equal(answer, response);
    }
}