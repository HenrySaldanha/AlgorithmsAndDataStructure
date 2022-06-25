namespace Problems.Test.Math;

public class ReverseIntegerTests
{
    [Theory]
    [InlineData(6554, 4556)]
    [InlineData(1111, 1111)]
    [InlineData(1234, 4321)]
    [InlineData(-123, -321)]
    [InlineData(-2147483647, 0)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int input, int answer)
    {
        //Arrange
        var solution = new ReverseInteger();

        //Act
        var response = solution.SolutionA(input);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(6554, 4556)]
    [InlineData(1111, 1111)]
    [InlineData(1234, 4321)]
    [InlineData(-123, -321)]
    [InlineData(-2147483647, 0)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int input, int answer)
    {
        //Arrange
        var solution = new ReverseInteger();

        //Act
        var response = solution.SolutionB(input);

        //Assert
        Assert.Equal(answer, response);
    }
}