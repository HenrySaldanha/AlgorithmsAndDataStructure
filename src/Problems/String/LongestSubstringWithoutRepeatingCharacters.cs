namespace Problems.String;

/// <summary>
/// Given a string s, find the length of the longest substring without repeating characters.
/// </summary>

/// <example>
/// Input: s = "abcabcbb"
/// Output: 3
/// Explanation: The answer is "abc", with the length of 3.
/// </example>

public class LongestSubstringWithoutRepeatingCharacters
{
    public int SolutionA(string s)
    {
        int count = 0;
        int iniIndex = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (Contains(s, iniIndex, i, s[i]))
                iniIndex++;

            if (i + 1 - iniIndex > count)
                count = i + 1 - iniIndex;
        }
        return count;
    }

    public bool Contains(string s, int ini, int end, char search)
    {
        for (int i = ini; i < end; i++)
        {
            if (s[i] == search)
                return true;
        }
        return false;
    }

    public int SolutionB(string s)
    {
        int count = 0;
        int iniIndex = 0;

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < s.Length; i++)
        {
            while (dict.ContainsKey(s[i]))
            {
                dict.Remove(s[iniIndex]);
                iniIndex++;
            }

            dict[s[i]] = 1;

            if (i + 1 - iniIndex > count)
                count = i + 1 - iniIndex;
        }

        return count;
    }

}