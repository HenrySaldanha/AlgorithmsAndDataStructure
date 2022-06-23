using Problems.Array;

namespace Problems.Test.Array;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9)]
    [InlineData(new[] { 5, 75, 25 }, 100)]
    [InlineData(new[] { 0, 3, -3, 4, -1 }, -1)]
    [InlineData(new[] { 3, 2, 4 }, 6)]
    [InlineData(new[] { 3, 3 }, 6)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] array, int target)
    {
        //Arrange
        var solution = new TwoSum();

        //Act
        var response = solution.SolutionA(array, target);

        //Assert
        Assert.Equal(array[response[0]] + array[response[1]], target);
        Assert.True(response[0] < response[1]);
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9)]
    [InlineData(new[] { 5, 75, 25 }, 100)]
    [InlineData(new[] { 0, 3, -3, 4, -1 }, -1)]
    [InlineData(new[] { 3, 2, 4 }, 6)]
    [InlineData(new[] { 3, 3 }, 6)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] array, int target)
    {
        //Arrange
        var solution = new TwoSum();

        //Act
        var response = solution.SolutionB(array, target);

        //Assert
        Assert.Equal(array[response[0]] + array[response[1]], target);
        Assert.True(response[0] < response[1]);
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9)]
    [InlineData(new[] { 5, 75, 25 }, 100)]
    [InlineData(new[] { 0, 3, -3, 4, -1 }, -1)]
    [InlineData(new[] { 3, 2, 4 }, 6)]
    [InlineData(new[] { 3, 3 }, 6)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11)]
    public void SolutionC_ValidInput_MustReturnCorrectAnswer(int[] array, int target)
    {
        //Arrange
        var solution = new TwoSum();

        //Act
        var response = solution.SolutionC(array, target);

        //Assert
        Assert.Equal(array[response[0]] + array[response[1]], target);
        Assert.True(response[0] < response[1]);
    }
}