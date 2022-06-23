namespace Problems.Array;

/// <summary>
/// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the 
/// range that is missing from the array.
/// </summary>

/// <example>
/// Input: nums = [3,0,1]
/// Output: 2
/// </example>

/// <example>
/// Input: nums = [0,1]
/// Output: 2
/// </example>

public class MissingNumber
{


    public int SolutionA(int[] nums)
    {
        System.Array.Sort(nums);

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] + 1 != nums[i + 1])
                return nums[i] + 1;
        }

        if (nums[0] != 0)
            return 0;

        return nums[nums.Length - 1] + 1;
    }

    public int SolutionB(int[] nums)
    {
        var gauss = nums.Length * (nums.Length + 1) / 2;
        var sum = nums.Sum();
        return gauss - sum;
    }
}