namespace Problems.Array;
/// <summary>
/// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// </summary>

/// <example>
/// nums = [4,1,2,1,2]
/// Output: 4
/// </example>

public class SingleNumber
{
    public int SolutionA(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
            dict[nums[i]] = dict.ContainsKey(nums[i]) ? dict[nums[i]] + 1 : 1;

        foreach (var item in dict)
        {
            if (item.Value == 1)
                return item.Key;
        }

        return -1;
    }

    public int SolutionB(int[] nums)
    {
        var xor = 0;
        for (var i = 0; i < nums.Length; i++)
            xor = xor ^ nums[i];

        return xor;
    }
}