namespace Problems.String;

/// <summary>
/// You are given a string s, where every two consecutive vertical bars '|' are grouped into a pair.
/// In other words, the 1st and 2nd '|' make a pair, the 3rd and 4th '|' make a pair, and so forth.
/// Return the number of '*' in s, excluding the '*' between each pair of '|'.
/// Note that each '|' will belong to exactly one pair.
/// </summary>

/// <example>
/// Input: s = "l|*e*et|c**o|*de|"
/// Output: 2
/// </example>

public class CountAsterisks
{
    public int Solution(string s)
    {
        var open = false;
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '|')
                open = !open;
            else if (!open && s[i] == '*')
                count++;
        }
        return count;
    }
}
