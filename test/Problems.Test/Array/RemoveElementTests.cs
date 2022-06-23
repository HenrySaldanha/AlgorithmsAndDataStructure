using Problems.Array;

namespace Problems.Test.Array;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 2, 2)]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, int remove, int answer)
    {
        //Arrange
        var solution = new RemoveElement();

        //Act
        var response = solution.Solution(numbers, remove);

        //Assert
        Assert.Equal(answer, response);
    }
}