namespace Problems.Matrix;

/// <summary>
/// You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
/// You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
/// DO NOT allocate another 2D matrix and do the rotation.
/// </summary>

/// <example>
/// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
/// Output: [[7,4,1],[8,5,2],[9,6,3]]
/// </example>

public class RotateImage
{
    public void SolutionA(int[,] matrix)
    {
        //diagonal swap
        for (int r = 0; r < matrix.GetLength(0); r++)
            for (int c = r + 1; c < matrix.GetLength(0); c++)
                (matrix[r, c], matrix[c, r]) = (matrix[c, r], matrix[r, c]);

        //horizontal swap
        for (int r = 0; r < matrix.GetLength(0); r++)
            for (int c = 0; c < matrix.GetLength(0) / 2; c++)
                (matrix[r, c], matrix[r, matrix.GetLength(0) - c - 1]) = (matrix[r, matrix.GetLength(0) - c - 1], matrix[r, c]);
    }

    public void SolutionB(int[,] matrix)
    {
        var matrix2 = new int[matrix.GetLength(0), matrix.GetLength(0)];

        for (int r = 0; r < matrix.GetLength(0); r++)
            for (int c = 0; c < matrix.GetLength(0); c++)
                matrix2[r, c] = matrix[r, c];

        for (int r = 0; r < matrix.GetLength(0); r++)
            for (int c = 0; c < matrix.GetLength(0); c++)
                matrix[r, c] = matrix2[matrix.GetLength(0) - c - 1, r];
    }
}