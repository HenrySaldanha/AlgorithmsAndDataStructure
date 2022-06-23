using Problems.Array;

namespace Problems.Test.Array;

public class MergeIntervalsTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new MergeIntervals();
        int[][] nums = new int[3][];
        nums[0] = new int[2] { 1, 6 };
        nums[1] = new int[2] { 2, 3 };
        nums[2] = new int[2] { 7, 9 };

        //Act
        var response = solution.Solution(nums);

        //Assert
        Assert.Equal(nums[0], response[0]);
        Assert.Equal(nums[2], response[1]);
    }
}