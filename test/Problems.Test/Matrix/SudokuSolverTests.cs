namespace Problems.Test.Matrix;

public class SudokuSolverTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new SudokuSolver();

        var input = new char[,]
        {
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'},
        };

        var expectedResponse = new char[,]
        {
                {'5','3','4','6','7','8','9','1','2'},
                {'6','7','2','1','9','5','3','4','8'},
                {'1','9','8','3','4','2','5','6','7'},
                {'8','5','9','7','6','1','4','2','3'},
                {'4','2','6','8','5','3','7','9','1'},
                {'7','1','3','9','2','4','8','5','6'},
                {'9','6','1','5','3','7','2','8','4'},
                {'2','8','7','4','1','9','6','3','5'},
                {'3','4','5','2','8','6','1','7','9'},
        };

        //Act
        solution.Solution(input);

        //Assert
        Assert.True(input[0, 0] == expectedResponse[0, 0]);
        Assert.True(input[0, 1] == expectedResponse[0, 1]);
        Assert.True(input[0, 2] == expectedResponse[0, 2]);
        Assert.True(input[0, 3] == expectedResponse[0, 3]);
        Assert.True(input[0, 4] == expectedResponse[0, 4]);
        Assert.True(input[0, 5] == expectedResponse[0, 5]);
        Assert.True(input[0, 6] == expectedResponse[0, 6]);
        Assert.True(input[0, 7] == expectedResponse[0, 7]);
    }
}