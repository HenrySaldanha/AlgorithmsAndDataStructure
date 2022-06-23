namespace Problems.Sorting;

/// <summary>
/// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same
/// color are adjacent, with the colors in the order red, white, and blue.
/// We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
/// You must solve this problem without using the library's sort function.
/// </summary>

/// <example>
/// Input: nums = [2,0,2,1,1,0]
/// Output: [0,0,1,1,2,2]
/// </example>

/// <example>
/// Input: nums = [2,0,1]
/// Output: [0,1,2]
/// </example>

public class SortColors
{
    public void Solution(int[] nums)
    {

        if (nums.Length == 1)
            return;

        var zero = 0;
        var one = 0;
        var two = 0;
        var i = 0;

        foreach (var num in nums)
        {
            if (num == 0)
                zero++;
            else if (num == 1)
                one++;
            else if (num == 2)
                two++;
        }

        while (i < zero)
            nums[i++] = 0;

        while (i < zero + one)
            nums[i++] = 1;

        while (i < zero + one + two)
            nums[i++] = 2;
    }
}