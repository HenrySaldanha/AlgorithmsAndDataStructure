namespace Problems.Test.HashTable;

public class RansomNoteTests
{
    [Theory]
    [InlineData("aa", "aab", true)]
    [InlineData("ac", "abbc", true)]
    [InlineData("abc", "bdc", false)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string a, string b, bool responseExpected)
    {
        //Arrange
        var solution = new RansomNote();

        //Act
        var response = solution.Solution(a, b);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}