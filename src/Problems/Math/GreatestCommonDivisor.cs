namespace Problems.Math;

/// <summary>
/// Greatest Common Divisor: It is the highest number that completely divides two or more numbers. 
/// It is abbreviated for GCD. It is also known as the Greatest Common Factor (GCF) and the Highest Common Factor (HCF). 
/// It is used to simplify the fractions.
/// </summary>

/// <example>
/// Input: 9,6
/// Output: 3
/// Explanation: 3*2 = 6 
/// Explanation: 3*3 = 9 
/// </example>

public class GreatestCommonDivisor
{
    public object Solution(int a, int b)
    {
        if (b == 0)
            return a;

        return Solution(b, a % b);
    }
}