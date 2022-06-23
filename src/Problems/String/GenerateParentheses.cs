namespace Problems.String;

/// <summary>
/// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
/// </summary>

/// <example>
/// Input: n = 3
/// Output: ["((()))","(()())","(())()","()(())","()()()"]
/// </example>

public class GenerateParentheses
{
    public IEnumerable<string> Solution(int n)
    {
        var response = new List<string>();
        Backtrack(response, "", 0, 0, n);
        return response;
    }
    public void Backtrack(List<string> response, string currentValue, int open, int close, int n)
    {
        if (open == n && close == n)
        {
            response.Add(currentValue);
            return;
        }

        if (open < n)
        {
            currentValue += "(";
            Backtrack(response, currentValue, open + 1, close, n);
            currentValue = currentValue.Remove(currentValue.Length - 1);
        }

        if (close < open)
        {
            currentValue += ")";
            Backtrack(response, currentValue, open, close + 1, n);
        }
    }
}