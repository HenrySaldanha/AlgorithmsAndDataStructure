namespace Problems.Test.Sorting;

public class SuccessfulPairsOfSpellsAndPotionsTests
{
    [Theory]
    [InlineData(new[] { 5, 1, 3 }, new[] { 1, 2, 3, 4, 5 }, 7, new[] { 4, 0, 3 })]
    [InlineData(new[] { 3, 1, 2 }, new[] { 8, 5, 8 }, 16, new[] { 2, 0, 2 })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] spells, int[] potions, int success, int[] expectedResponse)
    {
        //Arrange
        var solution = new SuccessfulPairsOfSpellsAndPotions();

        //Act
        var response = solution.Solution(spells, potions, success);

        //Assert
        Assert.Equal(expectedResponse, response);
    }
}