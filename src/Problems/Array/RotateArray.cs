namespace Problems.Array;

/// <summary>
/// Given an array, rotate the array to the right by k steps, where k is non-negative.
/// </summary>

/// <example>
/// IInput: nums = [1,2,3,4,5,6,7], k = 3
/// Output: [5,6,7,1,2,3,4]
/// Explanation:
/// rotate 1 steps to the right: [7,1,2,3,4,5,6]
/// rotate 2 steps to the right: [6,7,1,2,3,4,5]
/// rotate 3 steps to the right: [5,6,7,1,2,3,4]
/// </example>

public class RotateArray
{
    public void SolutionA(int[] nums, int k)
    {
        var copyNums = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            copyNums[i] = nums[i];

        for (var i = 0; i < nums.Length; i++)
            nums[(k + i) % nums.Length] = copyNums[i];
    }

    public void SolutionB(int[] nums, int k)
    {
        k = k % nums.Length;

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }

        left = 0;
        right = k - 1;
        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }

        left = k;
        right = nums.Length - 1;
        while (left < right)
        {
            Swap(nums, left, right);
            left++;
            right--;
        }
    }

    private void Swap(int[] nums, int i, int j) =>
        (nums[j], nums[i]) = (nums[i], nums[j]);
}