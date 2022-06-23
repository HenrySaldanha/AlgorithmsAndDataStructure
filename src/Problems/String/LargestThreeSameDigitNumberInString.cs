namespace Problems.String;

/// <summary>
/// You are given a string num representing a large integer. An integer is good if it meets the following conditions:
/// It is a substring of num with length 3.
/// It consists of only one unique digit.
/// Return the maximum good integer as a string or an empty string "" if no such integer exists.
/// Note:
/// A substring is a contiguous sequence of characters within a string.
/// There may be leading zeroes in num or a good integer.
/// </summary>

/// <example>
/// Input: num = "6777133339"
/// Output: "777"
/// Explanation: There are two distinct good integers: "777" and "333".
/// "777" is the largest, so we return "777".
/// </example>

/// <example>
/// Input: num = "42352338"
/// Output: ""
/// </example>

public class LargestThreeSameDigitNumberInString
{
    public string Solution(string num)
    {
        if (num.Length < 3)
            return "";

        int maxIndex = -1;

        for (int i = 2; i < num.Length; i++)
        {
            if (num[i] == num[i - 1] && num[i] == num[i - 2])
            {
                if (maxIndex == -1)
                    maxIndex = i;
                else
                    maxIndex = (num[i] > num[maxIndex]) ? i : maxIndex;
            }
        }

        return maxIndex == -1 ? "" : $"{num[maxIndex]}{num[maxIndex]}{num[maxIndex]}";
    }
}