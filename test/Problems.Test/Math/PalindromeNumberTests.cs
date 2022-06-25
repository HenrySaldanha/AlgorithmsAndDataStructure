namespace Problems.Test.Math;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(885588, true)]
    [InlineData(-121, false)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int input, bool answer)
    {
        //Arrange
        var solution = new PalindromeNumber();

        //Act
        var response = solution.SolutionA(input);

        //Assert
        Assert.Equal(answer, response);
    }
}