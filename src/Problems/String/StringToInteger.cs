namespace Problems.String;

/// <summary>
/// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
/// </summary>

/// <example>
/// Input: s = "42"
/// Output: 42
/// </example>

/// <example>
/// Input: s = "   -42"
/// Output: -42
/// </example>

/// <example>
/// Input: s = "4193 with words"
/// Output: 4193
/// </example>
public class StringToInteger
{
    public int Solution(string s)
    {
        var i = 0;
        var positive = true;
        long number = 0;

        while (i < s.Length && s[i] == ' ')
            i++;

        if (i < s.Length && s[i] == '-')
        {
            positive = false;
            i++;
        }
        else if (i < s.Length && s[i] == '+')
        {
            positive = true;
            i++;
        }

        while (i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            number *= 10;
            number += s[i] - '0';

            if (positive && number > Int32.MaxValue)
                return Int32.MaxValue;
            if (!positive && number > Int32.MaxValue)
                return Int32.MinValue;

            i++;
        }

        return positive ? (int)number : (int)number * -1;
    }
}