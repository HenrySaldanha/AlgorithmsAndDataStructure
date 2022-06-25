namespace Problems.Test.Sorting;

public class ThreeSumClosestTests
{
    [Theory]
    [InlineData(new[] { -1, 2, 1, -4 }, 1, 2)]
    [InlineData(new[] { 0, 0, 0 }, 1, 0)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] nums, int target, int expectedResponse)
    {
        //Arrange
        var solution = new ThreeSumClosest();

        //Act
        var response = solution.Solution(nums, target);

        //Assert
        Assert.Equal(response, expectedResponse);
    }
}