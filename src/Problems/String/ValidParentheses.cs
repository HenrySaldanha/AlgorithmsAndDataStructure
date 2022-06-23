namespace Problems.String;

/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
/// </summary>

/// <example>
/// Input: s = "()[]{}"
/// Output: true
/// </example>

/// <example>
/// Input: s = "(]"
/// Output: false
/// </example>

public class ValidParentheses
{
    public bool Solution(string s)
    {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0)
                    return false;
                else if (s[i] == ')' && stack.Pop() != '(')
                    return false;
                else if (s[i] == ']' && stack.Pop() != '[')
                    return false;
                else if (s[i] == '}' && stack.Pop() != '{')
                    return false;
            }
        }

        return (stack.Count == 0);
    }
}