namespace Problems.String;

/// <summary>
/// Write a function that reverses a string. The input string is given as an array of characters s.
/// You must do this by modifying the input array in-place with O(1) extra memory.
/// </summary>

/// <example>
/// Input: s = ["h","e","l","l","o"]
/// Output: ["o","l","l","e","h"]
/// </example>

public class ReverseString
{
    public void Solution(char[] s)
    {
        var (left, right) = (0, s.Length - 1);

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}