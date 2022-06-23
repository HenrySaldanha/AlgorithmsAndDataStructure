namespace Problems.Math;

/// <summary>
/// Given an integer n, return the number of prime numbers that are strictly less than n.
/// </summary>

/// <example>
/// Input: n = 10
/// Output: 4
/// Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
/// </example>

public class CountPrimes
{
    public int Solution(int n)
    {
        var primes = new bool[n];
        var count = 0;

        for (int i = 0; i < primes.Length; i++)
            primes[i] = true;

        for (int i = 2; i * i < primes.Length; i++)
        {
            if (primes[i])
            {
                for (int j = i; j * i < primes.Length; j++)
                    primes[i * j] = false;
            }
        }

        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i])
                count++;
        }
        return count;
    }
}