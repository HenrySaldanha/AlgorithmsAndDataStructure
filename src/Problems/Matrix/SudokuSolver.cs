namespace Problems.Matrix;

/// <summary>
/// Write a program to solve a Sudoku puzzle by filling the empty cells.
/// A sudoku solution must satisfy all of the following rules:
/// Each row must contain the digits 1-9 without repetition.
/// Each column must contain the digits 1-9 without repetition.
/// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// The '.' character indicates empty cells.
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
/// [["5","3","4","6","7","8","9","1","2"]
/// ,["6","7","2","1","9","5","3","4","8"]
/// ,["1","9","8","3","4","2","5","6","7"]
/// ,["8","5","9","7","6","1","4","2","3"]
/// ,["4","2","6","8","5","3","7","9","1"]
/// ,["7","1","3","9","2","4","8","5","6"]
/// ,["9","6","1","5","3","7","2","8","4"]
/// ,["2","8","7","4","1","9","6","3","5"]
/// ,["3","4","5","2","8","6","1","7","9"]]
/// Output: false
/// Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. 
/// Since there are two 8's in the top left 3x3 sub-box, it is invalid.
/// </example>

public class SudokuSolver
{
    private HashSet<string> BoardValidation;

    public void Solution(char[,] board)
    {
        BoardValidation = new HashSet<string>();

        FillBoardValidation(board);
        Backtrack(board, 0, 0);
    }
    private bool Backtrack(char[,] board, int row, int col)
    {
        if (col == board.GetLength(0))
        {
            col = 0;
            row++;
            if (row == board.GetLength(1))
                return true;
        }

        if (board[row, col] != '.')
            return Backtrack(board, row, col + 1);

        for (var testValue = '1'; testValue <= '9'; testValue++)
        {
            if (!IsValidValue(row, col, testValue))
                continue;

            board[row, col] = testValue;
            AddBoardValidationValue(row, col, testValue);

            if (Backtrack(board, row, col + 1))
            {
                return true;
            }
            else
            {
                board[row, col] = '.';
                RemoveBoardValidationValue(row, col, testValue);
            }
        }

        return false;
    }

    private void FillBoardValidation(char[,] board)
    {
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                if (board[row, col] == '.')
                    continue;

                AddBoardValidationValue(row, col, board[row, col]);
            }
        }
    }

    private void AddBoardValidationValue(int row, int col, char val)
    {
        BoardValidation.Add($"R{row} {val}");
        BoardValidation.Add($"C{col} {val}");
        BoardValidation.Add($"G{row / 3}{col / 3} {val}");
    }

    private void RemoveBoardValidationValue(int row, int col, char val)
    {
        BoardValidation.Remove($"R{row} {val}");
        BoardValidation.Remove($"C{col} {val}");
        BoardValidation.Remove($"G{row / 3}{col / 3} {val}");
    }

    private bool IsValidValue(int row, int col, char val)
    {
        if (BoardValidation.Contains($"R{row} {val}") ||
            BoardValidation.Contains($"C{col} {val}") ||
            BoardValidation.Contains($"G{row / 3}{col / 3} {val}"))
            return false;

        return true;
    }
}