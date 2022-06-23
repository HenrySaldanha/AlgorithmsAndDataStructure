namespace Problems.Array;

/// <summary>
/// Given an integer array nums, return true if any value appears at least twice in the array,
/// and return false if every element is distinct.
/// </summary>

/// <example>
/// Input: nums = [1,2,3,1]
/// Output: true
/// </example>

/// <example>
/// Input: nums = [1,2,3,4]
/// Output: false
/// </example>

public class ContainsDuplicate
{
    public bool Solution(int[] nums)
    {
        var frequency = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (frequency.Contains(nums[i]))
                return true;

            frequency.Add(nums[i]);
        }

        return false;
    }
}