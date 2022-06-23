namespace Problems.Math;

/// <summary>
/// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes 
/// the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
/// </summary>

/// <example>
/// Input: 123
/// Output: 321
/// </example>

public class ReverseInteger
{
    public int SolutionA(int input)
    {
        long invertedValue = 0;

        var sign = input < 0;

        if (sign)
            input *= -1;

        while (input > 0)
        {
            invertedValue = (input % 10) + invertedValue * 10;
            input /= 10;
        }

        if (sign)
            invertedValue *= -1;

        if (invertedValue > int.MaxValue || invertedValue < int.MinValue)
            return 0;

        return (int)invertedValue;
    }

    public int SolutionB(int input)
    {
        var sign = input < 0 ? -1 : 1;
        input = input * sign;

        var s = input.ToString();
        s = new string(s.Reverse().ToArray());

        var result = long.Parse(s);

        if (result > int.MaxValue || result < int.MinValue)
            return 0;

        return sign * (int)result;
    }
}