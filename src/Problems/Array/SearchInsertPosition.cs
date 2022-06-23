namespace Problems.Array;

/// <summary>
/// Given a sorted array of distinct integers and a target value, return the index if the target is found. 
/// If not, return the index where it would be if it were inserted in order.
/// You must write an algorithm with O(log n) runtime complexity.
/// </summary>

/// <example>
/// Input: nums = [1,3,5,6], target = 5
/// Output: 2
/// </example>

/// <example>
/// Input: nums = [1,3,5,6], target = 2
/// Output: 1
/// </example>

public class SearchInsertPosition
{
    public int Solution(int[] nums, int target)
    {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }

    public int BinarySearch(int[] nums, int ini, int end, int target)
    {
        if (ini > end)
            return ini;

        var middle = ini + ((end - ini) / 2);

        if (nums[middle] == target)
            return middle;

        if (target < nums[middle])
            return BinarySearch(nums, ini, middle - 1, target);
        else
            return BinarySearch(nums, middle + 1, end, target);
    }
}
