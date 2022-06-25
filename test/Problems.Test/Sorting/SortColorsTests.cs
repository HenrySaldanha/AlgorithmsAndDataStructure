namespace Problems.Test.Sorting;

public class SortColorsTests
{
    [Theory]
    [InlineData(new[] { 2, 0, 2, 1, 1, 0 }, new[] { 0, 0, 1, 1, 2, 2 })]
    [InlineData(new[] { 2, 0, 1 }, new[] { 0, 1, 2 })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, int[] expectedResponse)
    {
        //Arrange
        var solution = new SortColors();

        //Act
        solution.Solution(numbers);

        //Assert
        Assert.Equal(numbers, expectedResponse);
    }
}