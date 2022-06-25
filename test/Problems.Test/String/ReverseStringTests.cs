namespace Problems.Test.String;

public class ReverseStringTests
{
    [Theory]
    [InlineData(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
    [InlineData(new[] { 'a', 'b', 'c' }, new[] { 'c', 'b', 'a' })]
    public void Solution_ValidInput_MustReturnCorrectAnswer(char[] input, char[] responseExpected)
    {
        //Arrange
        var solution = new ReverseString();

        //Act
        solution.Solution(input);

        //Assert
        Assert.Equal(responseExpected, input);
    }
}