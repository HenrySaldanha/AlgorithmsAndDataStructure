using Search.Linear;

namespace Search.Test.Linear;

public class LinearTests
{
    [Theory]
    [InlineData(-5)]
    [InlineData(4)]
    [InlineData(77777)]
    public void Exists_ValidKey_MustExists(int key)
    {
        //Arrange
        var array = new int[] { -5, 0, 1, 3, 4, 5, 234, 345, 456, 1111, 2222, 77777 };

        //Act
        var result = array.Exists(key);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(-15)]
    [InlineData(2)]
    [InlineData(77778)]
    public void Exists_ValidKey_MustNotExists(int key)
    {
        //Arrange
        var array = new int[] { -5, 0, 1, 3, 4, 5, 234, 345, 456, 1111, 2222, 77777 };

        //Act
        var result = array.Exists(key);

        //Assert
        Assert.False(result);
    }
}