namespace Problems.Array;

/// <summary>
/// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
/// </summary>

/// <example>
/// Input: nums = [0,1,0,3,12]
/// Output: [1,3,12,0,0]
/// </example>

public class MoveZeroes
{
    public void Solution(int[] nums)
    {
        var j = 0;
        var i = 0;
        while (i < nums.Length && j < nums.Length)
        {
            if (nums[j] != 0)
                nums[i++] = nums[j];
            j++;
        }

        while (i < nums.Length)
            nums[i++] = 0;
    }
}