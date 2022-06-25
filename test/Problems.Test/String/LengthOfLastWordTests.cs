namespace Problems.Test.String;

public class LengthOfLastWordTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(string array, int responseExpected)
    {


        var c = func1(200);

        //Arrange
        var solution = new LengthOfLastWord();



        //Act
        var response = solution.Solution(array);

        //Assert
        Assert.Equal(responseExpected, response);
    }


    public int func1(int x)
    {
        if (x <= 100)
            return x + 10;
        else
            return func1(func1(x / 5));
    }


}