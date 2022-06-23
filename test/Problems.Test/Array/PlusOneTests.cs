using Problems.Array;

namespace Problems.Test.Array;

public class PlusOneTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTheSameArray()
    {
        //Arrange
        var solution = new PlusOne();

        //Act
        var response = solution.Solution(new[] { 1, 2, 3, 4 });

        //Assert
        Assert.Equal(4, response.Length);
        Assert.Equal(1, response[0]);
        Assert.Equal(2, response[1]);
        Assert.Equal(3, response[2]);
        Assert.Equal(5, response[3]);
    }

    [Fact]
    public void Solution_ValidInput_MustReturnNewArray()
    {
        //Arrange
        var solution = new PlusOne();

        //Act
        var response = solution.Solution(new[] { 9, 9, 9, 9 });

        //Assert
        Assert.Equal(5, response.Length);
        Assert.Equal(1, response[0]);
        Assert.Equal(0, response[1]);
        Assert.Equal(0, response[2]);
        Assert.Equal(0, response[3]);
        Assert.Equal(0, response[4]);
    }
}