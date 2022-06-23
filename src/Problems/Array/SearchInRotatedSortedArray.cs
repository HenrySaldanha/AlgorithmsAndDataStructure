﻿namespace Problems.Array;

/// <summary>
/// There is an integer array nums sorted in ascending order (with distinct values).
/// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k(1 <= k<nums.length) 
/// such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0-indexed). 
/// For example, [0, 1, 2, 4, 5, 6, 7] might be rotated at pivot index 3 and become[4, 5, 6, 7, 0, 1, 2].
/// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, 
/// or -1 if it is not in nums.
/// </summary>

/// <example>
/// Input: nums = [4,5,6,7,0,1,2], target = 0
/// Output: 4
/// </example>

/// <example>
/// Input: nums = [4,5,6,7,0,1,2], target = 3
/// Output: -1
/// </example>
public class SearchInRotatedSortedArray
{
    public int Solution(int[] nums, int target)
    {
        if (nums.Length == 1 && target != nums[0])
            return -1;

        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var middle = left + ((right - left) / 2);

            if (nums[middle] == target)
                return middle;

            //left is sorted
            if (nums[left] <= nums[middle])
            {
                if (target > nums[middle] || target < nums[left])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            //right is sorted
            else
            {
                if (target < nums[middle] || target > nums[right])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
        }

        return -1;
    }

}