namespace Problems.Sorting;

/// <summary>
/// Assume you are an awesome parent and want to give your children some cookies. 
/// But, you should give each child at most one cookie.
/// Each child i has a greed factor g[i], which is the minimum size of a cookie 
/// that the child will be content with; and each cookie j has a size s[j]. If s[j] >= g[i], 
/// we can assign the cookie j to the child i, and the child i will be content. 
/// Your goal is to maximize the number of your content children and output the maximum number.
/// </summary>

/// <example>
/// Input: g = [1,2,3], s = [1,1]
/// Output: 1
/// </example>

public class AssignCookies
{
    public int Solution(int[] g, int[] s)
    {
        System.Array.Sort(g);
        System.Array.Sort(s);

        var i = 0;
        var j = 0;
        while (i < g.Length && j < s.Length)
        {
            if (g[i] <= s[j])
                i++;
            j++;
        }
        return i;
    }
}