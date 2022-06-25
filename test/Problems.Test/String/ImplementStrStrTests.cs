namespace Problems.Test.String;

public class ImplementStrStrTests
{
    [Theory]
    [InlineData("hello", "ll", 2)]
    [InlineData("a", "a", 0)]
    [InlineData("aaaaa", "a", 0)]
    [InlineData("aaaaa", "bba", -1)]
    [InlineData("abc", "c", 2)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string a, string b, int responseExpected)
    {
        //Arrange
        var solution = new ImplementStrStr();

        //Act
        var response = solution.Solution(a, b);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}