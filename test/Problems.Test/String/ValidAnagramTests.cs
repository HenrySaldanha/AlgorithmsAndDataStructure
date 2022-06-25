namespace Problems.Test.String;

public class ValidAnagramTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("nagaram", "anagram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("car", "rat", false)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string a, string b, bool responseExpected)
    {
        //Arrange
        var solution = new ValidAnagram();

        //Act
        var response = solution.Solution(a, b);

        //Assert
        Assert.Equal(responseExpected, response);
    }
}