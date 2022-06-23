using Problems.Array;

namespace Problems.Test.Array;

public class SingleNumberTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 4, 1 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] array, int answer)
    {
        //Arrange
        var solution = new SingleNumber();

        //Act
        var response = solution.SolutionA(array);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 2, 4, 1 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] array, int answer)
    {
        //Arrange
        var solution = new SingleNumber();

        //Act
        var response = solution.SolutionB(array);

        //Assert
        Assert.Equal(answer, response);
    }
}