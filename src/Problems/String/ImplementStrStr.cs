namespace Problems.String;

/// <summary>
/// Implement strStr().
/// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
/// or -1 if needle is not part of haystack.
/// </summary>

/// <example>
/// Input: haystack = "hello", needle = "ll"
/// Output: 2
/// </example>

public class ImplementStrStr
{
    public int Solution(string haystack, string needle)
    {
        for (var i = 0; i < haystack.Length; i++)
        {
            if (needle.Length + i > haystack.Length)
                return -1;

            if (haystack.Substring(i, needle.Length) == needle)
                return i;
        }

        return -1;
    }
}