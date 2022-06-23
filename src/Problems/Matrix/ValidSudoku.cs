namespace Problems.Matrix;

/// <summary>
/// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
/// Each row must contain the digits 1-9 without repetition.
/// Each column must contain the digits 1-9 without repetition.
/// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// </summary>

/// <example>
/// Input: board = 
/// [["5","3",".",".","7",".",".",".","."]
/// ,["6",".",".","1","9","5",".",".","."]
/// ,[".","9","8",".",".",".",".","6","."]
/// ,["8",".",".",".","6",".",".",".","3"]
/// ,["4",".",".","8",".","3",".",".","1"]
/// ,["7",".",".",".","2",".",".",".","6"]
/// ,[".","6",".",".",".",".","2","8","."]
/// ,[".",".",".","4","1","9",".",".","5"]
/// ,[".",".",".",".","8",".",".","7","9"]]
/// Output: true
/// </example>

/// <example>
/// Input: board = 
/// [["8","3",".",".","7",".",".",".","."]
/// ,["6",".",".","1","9","5",".",".","."]
/// ,[".","9","8",".",".",".",".","6","."]
/// ,["8",".",".",".","6",".",".",".","3"]
/// ,["4",".",".","8",".","3",".",".","1"]
/// ,["7",".",".",".","2",".",".",".","6"]
/// ,[".","6",".",".",".",".","2","8","."]
/// ,[".",".",".","4","1","9",".",".","5"]
/// ,[".",".",".",".","8",".",".","7","9"]]
/// Output: false
/// Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. 
/// Since there are two 8's in the top left 3x3 sub-box, it is invalid.
/// </example>

public class ValidSudoku
{
    public bool Solution(char[,] board)
    {
        var rowSet = new HashSet<string>();
        var colSet = new HashSet<string>();
        var group = new HashSet<string>();

        for (var r = 0; r < board.GetLength(0); r++)
        {
            for (var c = 0; c < board.GetLength(1); c++)
            {
                if (board[r, c] == '.')
                    continue;

                if (rowSet.Contains($"{r} {board[r, c]}") ||
                    colSet.Contains($"{c} {board[r, c]}") ||
                    group.Contains($"{r / 3}{c / 3} {board[r, c]}"))
                    return false;

                rowSet.Add($"{r} {board[r, c]}");
                colSet.Add($"{c} {board[r, c]}");
                group.Add($"{r / 3}{c / 3} {board[r, c]}");
            }
        }

        return true;
    }

}