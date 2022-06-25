namespace Problems.Test.Sorting;

public class RelativeRanksTests
{
    [Theory]
    [InlineData(new[] { 5, 4, 3, 2, 1 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" })]
    [InlineData(new[] { 10, 3, 8, 9, 4 }, new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers, string[] expectedResponse)
    {
        //Arrange
        var solution = new RelativeRanks();

        //Act
        var response = solution.Solution(numbers);

        //Assert
        Assert.Equal(response, expectedResponse);
    }
}