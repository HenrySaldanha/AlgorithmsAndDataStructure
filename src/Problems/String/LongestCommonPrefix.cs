namespace Problems.String;

/// <summary>
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// </summary>

/// <example>
/// Input: strs = ["flower","flow","flight"]
/// Output: "fl"
/// </example>

public class LongestCommonPrefix
{
    public string Solution(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        var prefix = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
                prefix = prefix.Remove(prefix.Length - 1);
        }
        return prefix;
    }
}