using Problems.Array;

namespace Problems.Test.Array;

public class PartitionEqualSubsetSumTests
{
    [Theory]
    [InlineData(new[] { 1, 5, 11, 5 }, true)]
    [InlineData(new[] { 1, 2, 3, 5 }, false)]
    [InlineData(new[] { 3, 4, 5, 2 }, true)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, bool answer)
    {
        //Arrange
        var solution = new PartitionEqualSubsetSum();

        //Act
        var response = solution.Solution(numbers);

        //Assert
        Assert.Equal(answer, response);
    }
}