using Problems.Array;

namespace Problems.Test.Array;

public class IntersectionOfTwoArraysIITests
{
    [Fact]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new IntersectionOfTwoArraysII();

        //Act
        var response = solution.SolutionA(new[] { 1, 2, 3 }, new[] { 1, 2 });

        //Assert
        Assert.Equal(2, response.Length);
        Assert.Equal(1, response[0]);
        Assert.Equal(2, response[1]);
    }

    [Fact]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new IntersectionOfTwoArraysII();

        //Act
        var response = solution.SolutionB(new[] { 1, 2, 3 }, new[] { 1, 2 });

        //Assert
        Assert.Equal(2, response.Length);
        Assert.Equal(1, response[0]);
        Assert.Equal(2, response[1]);
    }
}