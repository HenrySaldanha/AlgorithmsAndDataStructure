using Problems.Array;

namespace Problems.Test.Array;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 3 }, 2)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] numbers, int answer)
    {
        //Arrange
        var solution = new RemoveDuplicatesFromSortedArray();

        //Act
        var response = solution.SolutionA(numbers);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(new[] { 1, 1, 3 }, 2)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] numbers, int answer)
    {
        //Arrange
        var solution = new RemoveDuplicatesFromSortedArray();

        //Act
        var response = solution.SolutionB(numbers);

        //Assert
        Assert.Equal(answer, response);
    }
}