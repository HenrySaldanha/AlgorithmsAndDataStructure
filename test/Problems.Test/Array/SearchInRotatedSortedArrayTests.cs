using Problems.Array;

namespace Problems.Test.Array;

public class SearchInRotatedSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new[] { 5, 1, 3 }, 3, 2)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, int remove, int answer)
    {
        //Arrange
        var solution = new SearchInRotatedSortedArray();

        //Act
        var response = solution.Solution(numbers, remove);

        //Assert
        Assert.Equal(answer, response);
    }
}