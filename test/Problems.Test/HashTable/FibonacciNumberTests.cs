namespace Problems.Test.HashTable;

public class FibonacciNumberTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(9, 34)]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int fib, int answer)
    {
        //Arrange
        var solution = new FibonacciNumber();

        //Act
        var response = solution.SolutionA(fib);

        //Assert
        Assert.Equal(answer, response);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(9, 34)]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int fib, int answer)
    {
        //Arrange
        var solution = new FibonacciNumber();

        //Act
        var response = solution.SolutionB(fib);

        //Assert
        Assert.Equal(answer, response);
    }
}