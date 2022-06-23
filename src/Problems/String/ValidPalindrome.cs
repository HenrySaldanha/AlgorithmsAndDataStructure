namespace Problems.String;

/// <summary>
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing 
/// all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
/// Given a string s, return true if it is a palindrome, or false otherwise.
/// </summary>

/// <example>
/// Input: s = "A man, a plan, a canal: Panama"
/// Output: true
/// </example>

/// <example>
/// Input: s = "race a car"
/// Output: false
/// </example>

public class ValidPalindrome
{
    public bool Solution(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (IsLetterOrNumber(s[left]) && IsLetterOrNumber(s[right]))
            {
                if (ToUpper(s[left]) != ToUpper(s[right]))
                    return false;

                left++;
                right--;
            }
            else
            {
                if (!IsLetterOrNumber(s[left]))
                    left++;

                if (!IsLetterOrNumber(s[right]))
                    right--;
            }
        }

        return true;
    }
    private bool IsLetterOrNumber(char input) =>
        input >= 'a' && input <= 'z' ||
        input >= 'A' && input <= 'Z' ||
        input >= '0' && input <= '9';

    private char ToUpper(char input) =>
        input >= 'a' && input <= 'z' ? ((char)(input - 32)) : input;
}