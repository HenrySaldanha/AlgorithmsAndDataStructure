using Problems.Array;

namespace Problems.Test.Array;

public class MoveZeroesTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 2, 3 }, new[] { 1, 2, 3, 0, 0 })]
    [InlineData(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] nums, int[] answer)
    {
        //Arrange
        var solution = new MoveZeroes();

        //Act
        solution.Solution(nums);

        //Assert
        Assert.Equal(answer[0], nums[0]);
        Assert.Equal(answer[1], nums[1]);
        Assert.Equal(answer[2], nums[2]);
    }
}