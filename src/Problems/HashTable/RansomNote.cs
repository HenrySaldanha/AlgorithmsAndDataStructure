namespace Problems.HashTable;

/// <summary>
/// Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
/// Each letter in magazine can only be used once in ransomNote.
/// </summary>

/// <example>
/// Input: ransomNote = "a", magazine = "b"
/// Output: false
/// </example>

/// <example>
/// Input: ransomNote = "aa", magazine = "aab"
/// Output: true
/// </example>

public class RansomNote
{
    public bool Solution(string ransomNote, string magazine)
    {
        var chars = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (chars.ContainsKey(magazine[i]))
                chars[magazine[i]]++;
            else
                chars[magazine[i]] = 1;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!chars.ContainsKey(ransomNote[i]) || chars[ransomNote[i]] == 0)
                return false;

            chars[ransomNote[i]]--;
        }

        return true;
    }
}