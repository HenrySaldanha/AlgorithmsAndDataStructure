namespace Problems.String;

/// <summary>
/// Given two binary strings a and b, return their sum as a binary string.
/// </summary>

/// <example>
/// Input: a = "1010", b = "1011"
/// Output: "10101"
/// </example>

public class AddBinary
{
    public string Solution(string a, string b)
    {
        var response = "";

        if (a.Length < b.Length)
            return Solution(b, a);

        var bIndex = b.Length - 1;
        var carry = '0';

        for (int i = a.Length - 1; i >= 0; i--)
        {
            var bValue = (bIndex >= 0) ? b[bIndex] : '0';

            (var sum, carry) = Sum(a[i], bValue, carry);

            response = sum + response;

            bIndex--;
        }

        if (carry == '1')
            response = "1" + response;

        return response;
    }

    private (char, char) Sum(char a, char b, char carry)
    {
        if (a == '1' && b == '1')
            return (carry, '1');

        if (a == '0' && b == '0')
            return (carry, '0');

        if (carry == '0')
            return ('1', '0');
        else
            return ('0', '1');
    }

}