namespace Problems.String;

/// <summary>
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
/// typically using all the original letters exactly once.
/// </summary>

/// <example>
/// Input: s = "anagram", t = "nagaram"
/// Output: true
/// </example>

/// <example>
/// Input: s = "rat", t = "car"
/// Output: false
/// </example>

public class ValidAnagram
{
    public bool Solution(string s, string t)
    {
        var charactersSet = new Dictionary<char, int>();

        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (charactersSet.ContainsKey(s[i]))
                charactersSet[s[i]] = charactersSet[s[i]] + 1;
            else
                charactersSet[s[i]] = 1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (charactersSet.ContainsKey(t[i]))
            {
                var frequency = charactersSet[t[i]];

                if (frequency == 1)
                    charactersSet.Remove(t[i]);
                else
                    charactersSet[t[i]] = charactersSet[t[i]] - 1;
            }
            else
            {
                charactersSet[t[i]] = -1;
            }
        }

        return charactersSet.Count == 0;
    }
}