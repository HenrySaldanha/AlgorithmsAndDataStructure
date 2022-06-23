namespace Problems.String;

/// <summary>
/// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
/// </summary>

/// <example>
/// Input: s = "leetcode"
/// Output: 0
/// </example>

/// <example>
/// Input: s = "loveleetcode"
/// Output: 2
/// </example>

public class FirstUniqueCharacterInAString
{
    public int Solution(string s)
    {
        var array = new char[26];

        for (var i = 0; i < s.Length; i++)
        {
            array[s[i] - 'a']++;
        }

        for (var i = 0; i < s.Length; i++)
        {
            if (array[s[i] - 'a'] == 1)
                return i;
        }
        return -1;
    }
}