namespace Problems.Test.String;

public class StrongPasswordCheckerIITests
{
    [Theory]
    [InlineData("IloveLe3tcode!")]
    public void Solution_ValidInput_MustReturnTrue(string password)
    {
        //Arrange
        var solution = new StrongPasswordCheckerII();

        //Act
        var response = solution.Solution(password);

        //Assert
        Assert.True(response);
    }

    [Theory]
    [InlineData("Me+You--IsMyDream")]
    [InlineData("Me+YouIsMyDream")]
    [InlineData("IlooveLe3tcode!")]
    [InlineData("1aB!")]
    public void Solution_ValidInput_MustReturnFalse(string password)
    {
        //Arrange
        var solution = new StrongPasswordCheckerII();

        //Act
        var response = solution.Solution(password);

        //Assert
        Assert.False(response);
    }
}