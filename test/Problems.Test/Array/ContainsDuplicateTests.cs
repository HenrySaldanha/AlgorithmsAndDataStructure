using Problems.Array;

namespace Problems.Test.Array;
public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, bool answer)
    {
        //Arrange
        var solution = new ContainsDuplicate();

        //Act
        var response = solution.Solution(numbers);

        //Assert
        Assert.Equal(answer, response);
    }
}