namespace Problems.HashTable;

/// <summary>
/// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
/// typically using all the original letters exactly once.
/// </summary>

/// <example>
/// Input: strs = ["eat","tea","tan","ate","nat","bat"]
/// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
/// </example>

public class GroupAnagrams
{
    public IList<IList<string>> Solution(string[] strs)
    {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var s in strs)
        {
            var letters = GetTemplateCode();
            for (var i = 0; i < s.Length; i++)
                letters[s[i] - 'a']++;

            var stringCode = new string(letters);
            if (dict.ContainsKey(stringCode))
                dict[stringCode].Add(s);
            else
                dict[stringCode] = new List<string>() { s };
        }

        return dict.Values.ToList();
    }

    private char[] GetTemplateCode()
    {
        return new char[]
            { (char)0, (char)0, (char)0, (char)0,
              (char)0, (char)0, (char)0, (char)0, (char)0,
              (char)0, (char)0, (char)0, (char)0, (char)0,
              (char)0, (char)0, (char)0, (char)0, (char)0,
              (char)0, (char)0, (char)0, (char)0, (char)0,
              (char)0 , (char)0 , (char)0 };
    }
}