namespace Problems.Test.Matrix;

public class RotateImageTests
{
    [Fact]
    public void SolutionA_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new RotateImage();

        var input = new int[,]
        {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 },
        };

        var expectedResponse = new int[,]
        {
                { 7,4,1 },
                { 8,5,2 },
                { 9,6,3 },
        };

        //Act
        solution.SolutionA(input);

        //Assert
        Assert.True(input[0, 0] == expectedResponse[0, 0]);
        Assert.True(input[0, 1] == expectedResponse[0, 1]);
        Assert.True(input[0, 2] == expectedResponse[0, 2]);
        Assert.True(input[1, 0] == expectedResponse[1, 0]);
        Assert.True(input[1, 1] == expectedResponse[1, 1]);
        Assert.True(input[1, 2] == expectedResponse[1, 2]);
        Assert.True(input[2, 0] == expectedResponse[2, 0]);
        Assert.True(input[2, 1] == expectedResponse[2, 1]);
        Assert.True(input[2, 2] == expectedResponse[2, 2]);
    }

    [Fact]
    public void SolutionB_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new RotateImage();

        var input = new int[,]
        {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 },
        };

        var expectedResponse = new int[,]
        {
                { 7,4,1 },
                { 8,5,2 },
                { 9,6,3 },
        };

        //Act
        solution.SolutionB(input);

        //Assert
        Assert.True(input[0, 0] == expectedResponse[0, 0]);
        Assert.True(input[0, 1] == expectedResponse[0, 1]);
        Assert.True(input[0, 2] == expectedResponse[0, 2]);
        Assert.True(input[1, 0] == expectedResponse[1, 0]);
        Assert.True(input[1, 1] == expectedResponse[1, 1]);
        Assert.True(input[1, 2] == expectedResponse[1, 2]);
        Assert.True(input[2, 0] == expectedResponse[2, 0]);
        Assert.True(input[2, 1] == expectedResponse[2, 1]);
        Assert.True(input[2, 2] == expectedResponse[2, 2]);
    }
}