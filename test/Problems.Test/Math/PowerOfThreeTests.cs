namespace Problems.Test.Math;

public class PowerOfThreeTests
{
    [Theory]
    [InlineData(81, true)]
    [InlineData(4782969, true)]
    [InlineData(0, false)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int input, bool answer)
    {
        //Arrange
        var solution = new PowerOfThree();

        //Act
        var response = solution.SolutionA(input);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(81, true)]
    [InlineData(4782969, true)]
    [InlineData(0, false)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int input, bool answer)
    {
        //Arrange
        var solution = new PowerOfThree();

        //Act
        var response = solution.SolutionB(input);

        //Assert
        Assert.Equal(answer, response);
    }
}