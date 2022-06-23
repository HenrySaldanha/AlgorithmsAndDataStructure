namespace Problems.HashTable;

/// <summary>
/// The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, 
/// such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
/// F(0) = 0, F(1) = 1
/// F(n) = F(n - 1) + F(n - 2), for n > 1.
/// </summary>

/// <example>
/// Input: n = 3
/// Output: 2
/// Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.
/// </example>

public class FibonacciNumber
{
    public int SolutionA(int fib)
    {
        if (fib == 0)
            return 0;

        if (fib == 1)
            return 1;

        return SolutionA(fib - 1) + SolutionA(fib - 2);
    }

    public int SolutionB(int fib)
    {
        return FibWithHash(fib, new Dictionary<int, int>());
    }

    private int FibWithHash(int fib, Dictionary<int, int> dict)
    {
        if (fib <= 1)
            return fib;

        if (dict.ContainsKey(fib))
        {
            return dict[fib];
        }
        else
        {
            dict[fib] = FibWithHash(fib - 1, dict) + FibWithHash(fib - 2, dict);
            return dict[fib];
        }
    }
}