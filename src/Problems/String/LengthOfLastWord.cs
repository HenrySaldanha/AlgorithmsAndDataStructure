namespace Problems.String;

/// <summary>
/// Given a string s consisting of words and spaces, return the length of the last word in the string.
/// A word is a maximal substring consisting of non-space characters only.
/// </summary>

/// <example>
/// Input: s = "Hello World"
/// Output: 5
/// Explanation: The last word is "World" with length 5.
/// </example>

public class LengthOfLastWord
{
    public int Solution(string s)
    {
        var count = 0;
        var i = s.Length - 1;

        while (i >= 0 && s[i] == ' ')
            i--;

        while (i >= 0 && s[i] != ' ')
        {
            i--;
            count++;
        }

        return count;
    }
}