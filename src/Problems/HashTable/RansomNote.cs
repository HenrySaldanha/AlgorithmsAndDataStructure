namespace Problems.HashTable
{
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
}
