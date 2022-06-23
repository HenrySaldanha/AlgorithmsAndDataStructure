using Problems.Array;

namespace Problems.Test.Array;

public class RotateArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 5, 6, 7, 1, 2, 3, 4 }, 3)]
    [InlineData(new[] { -1, -100, 3, 99 }, new[] { 3, 99, -1, -100 }, 2)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] input, int[] response, int k)
    {
        //Arrange
        var solution = new RotateArray();

        //Act
        solution.SolutionA(input, k);


        //Assert
        Assert.Equal(input[0], response[0]);
        Assert.Equal(input[1], response[1]);
        Assert.Equal(input[2], response[2]);
        Assert.Equal(input[3], response[3]);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 5, 6, 7, 1, 2, 3, 4 }, 3)]
    [InlineData(new[] { -1, -100, 3, 99 }, new[] { 3, 99, -1, -100 }, 2)]
    [InlineData(new[] { -1, -100, 3, 99 }, new[] { 3, 99, -1, -100 }, 6)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] input, int[] response, int k)
    {
        //Arrange
        var solution = new RotateArray();

        //Act
        solution.SolutionB(input, k);

        //Assert
        Assert.Equal(input[0], response[0]);
        Assert.Equal(input[1], response[1]);
        Assert.Equal(input[2], response[2]);
        Assert.Equal(input[3], response[3]);
    }
}