using Problems.Array;

namespace Problems.Test.Array;

public class MedianOfTwoSortedArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0)]
    [InlineData(null, new[] { 1 }, 1)]
    [InlineData(new int[] { 0, 0, 0, 0, 0 }, new[] { -1, 0, 0, 0, 0, 0, 1 }, 0)]
    [InlineData(null, new[] { 2, 3 }, 2.5)]
    [InlineData(new[] { 2, 2, 4, 4 }, new[] { 2, 2, 4, 4 }, 3)]
    [InlineData(new[] { 1, 1 }, new[] { 1, 2 }, 1)]
    [InlineData(new[] { 1, 2 }, new[] { -1, 3 }, 1.5)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] array1, int[] array2, double answer)
    {
        //Arrange
        var solution = new MedianOfTwoSortedArrays();

        //Act
        var response = solution.Solution(array1 ?? System.Array.Empty<int>(), array2);

        //Assert
        Assert.Equal(answer, response);
    }
}