namespace Problems.Array;

/// <summary>
/// You are given a large integer represented as an integer array digits, where each digits[i] is the ith 
/// digit of the integer. The digits are ordered from most significant to least significant in left-to-right order.
/// The large integer does not contain any leading 0's.
/// Increment the large integer by one and return the resulting array of digits.
/// </summary>

/// <example>
/// Input: digits = [1,2,3]
/// Output: [1,2,4]
/// Explanation: The array represents the integer 123.
/// Incrementing by one gives 123 + 1 = 124.
/// Thus, the result should be[1, 2, 4].
/// </example>

public class PlusOne
{
    public int[] Solution(int[] digits)
    {
        var carry = 0;
        digits[digits.Length - 1]++;

        if (digits[digits.Length - 1] < 10)
            return digits;

        var response = new int[digits.Length + 1];

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var newCarry = (digits[i] + carry) / 10;
            digits[i] = (digits[i] + carry) % 10;
            response[i + 1] = digits[i];
            carry = newCarry;
        }

        if (carry == 0)
            return digits;

        response[0] = carry;
        return response;
    }
}