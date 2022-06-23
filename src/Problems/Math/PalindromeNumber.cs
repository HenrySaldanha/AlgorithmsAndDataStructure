namespace Problems.Math;

/// <summary>
/// Given an integer x, return true if x is palindrome integer.
/// An integer is a palindrome when it reads the same backward as forward.
/// </summary>

/// <example>
/// Input: x = 121
/// Output: true
/// </example>

/// <example>
/// Input: x = -121
/// Output: false
/// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
/// </example>
public class PalindromeNumber
{
    public bool SolutionA(int x)
    {
        if (x < 0)
            return false;

        var aux = x; //121
        var p = 0;

        while (aux / 10 > 0)
        {
            p = p * 10 + (aux % 10);
            aux /= 10;
        }
        p = p * 10 + (aux % 10);

        return p == x;
    }
}