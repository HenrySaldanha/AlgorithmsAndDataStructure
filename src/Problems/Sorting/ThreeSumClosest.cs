namespace Problems.Sorting;

/// <summary>
/// Given an integer array nums of length n and an integer target, 
/// find three integers in nums such that the sum is closest to target.
/// Return the sum of the three integers.
/// You may assume that each input would have exactly one solution.
/// </summary>

/// <example>
/// Input: nums = [-1,2,1,-4], target = 1
/// Output: 2
/// </example>

/// <example>
/// Input: nums = [0,0,0], target = 1
/// Output: 0
/// </example>

public class ThreeSumClosest
{
    public int Solution(int[] nums, int target)
    {
        System.Array.Sort(nums);
        var sumTarget = nums[0] + nums[1] + nums[2];

        for (var i = 0; i < nums.Length; i++)
        {
            var leftIndex = i + 1;
            var rightIndex = nums.Length - 1;
            while (leftIndex < rightIndex)
            {
                var sum = nums[leftIndex] + nums[i] + nums[rightIndex];

                if (System.Math.Abs(sum - target) < System.Math.Abs(sumTarget - target))
                    sumTarget = sum;

                if (sum == target)
                    return sum;

                if (sum > target)
                    rightIndex--;
                else
                    leftIndex++;
            }
        }

        return sumTarget;
    }
}