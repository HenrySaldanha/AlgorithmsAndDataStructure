using Problems.Array;

namespace Problems.Test.Array;

public class MissingNumberTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 2, 3 }, 4)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 8, 1 }, 0)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] nums, int answer)
    {
        //Arrange
        var solution = new MissingNumber();

        //Act
        var response = solution.SolutionA(nums);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(new[] { 0, 1, 2, 3 }, 4)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 8, 1 }, 0)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] nums, int answer)
    {
        //Arrange
        var solution = new MissingNumber();

        //Act
        var response = solution.SolutionB(nums);

        //Assert
        Assert.Equal(answer, response);
    }
}