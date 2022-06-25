namespace Problems.Test.Matrix;

public class ValidSudokuTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new ValidSudoku();
        var input = new char[,]
        {
                {'.','8','7','6','5','4','3','2','1' } ,
                {'2','.','.','.','.','.','.','.','.' } ,
                {'3','.','.','.','.','.','.','.','.'} ,
                {'4','.','.','.','.','.','.','.','.' } ,
                {'5','.','.','.','.','.','.','.','.' } ,
                {'6','.','.','.','.','.','.','.','.' } ,
                {'7','.','.','.','.','.','.','.','.'} ,
                {'8','.','.','.','.','.','.','.','.' } ,
                {'9','.','.','.','.','.','.','.','.' } ,
        };

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.True(response);
    }

    [Fact]
    public void Solution_InvalidInput_MustReturnFalse()
    {
        //Arrange
        var solution = new ValidSudoku();
        var input = new char[,]
        {
                {'5','3','.','.','7','.','.','.','.' } ,
                {'6','.','.','1','9','5','.','.','.' } ,
                {'.','9','8','.','.','.','.','6','.'} ,
                {'8','.','.','.','6','.','.','.','3' } ,
                {'4','.','.','8','.','3','.','.','1' } ,
                {'7','.','.','.','2','.','.','.','6' } ,
                {'.','6','.','.','.','.','2','8','.'} ,
                {'.','.','.','4','1','9','.','.','5' } ,
                {'.','.','.','.','8','.','2','7','9' } ,
        };

        //Act
        var response = solution.Solution(input);

        //Assert
        Assert.False(response);
    }
}