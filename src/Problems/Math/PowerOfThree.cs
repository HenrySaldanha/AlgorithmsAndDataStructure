namespace Problems.Math;

/// <summary>
/// Given an integer n, return true if it is a power of three. Otherwise, return false.
/// An integer n is a power of three, if there exists an integer x such that n == 3^x.
/// </summary>

/// <example>
/// Input: n = 27
/// Output: true
/// </example>

/// <example>
/// Input: n = 0
/// Output: false
/// </example>

public class PowerOfThree
{
    public bool SolutionA(int n)
    {
        //1162261467 = 3^19 (maximum value for int)
        return n > 0 && 1162261467 % n == 0;
    }

    public bool SolutionB(int n)
    {
        if (n <= 0)
            return false;

        while (n % 3 == 0)
            n = n / 3;

        return n == 1;
    }
}