namespace Problems.Array;

/// <summary>
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// </summary>

/// <example>
/// Input: nums1 = [1,3], nums2 = [2]
/// Output: 2.00000
/// Explanation: merged array = [1,2,3] and median is 2.
/// </example>

public class MedianOfTwoSortedArrays
{
    public double Solution(int[] nums1, int[] nums2)
    {
        var index1 = 0;
        var index2 = 0;

        var currentValue = 0.0;

        if (((nums1.Length + nums2.Length) % 2 != 0))
        {
            var middle = (nums1.Length + nums2.Length - 1) / 2;

            for (var i = 0; i <= middle; i++)
            {
                if (index1 < nums1.Length && index2 < nums2.Length)
                    currentValue = (nums1[index1] <= nums2[index2]) ? nums1[index1++] : nums2[index2++];

                else if (index1 < nums1.Length)
                    currentValue = nums1[index1++];

                else if (index2 < nums2.Length)
                    currentValue = nums2[index2++];
            }
            return currentValue;
        }
        else
        {
            var middle1 = ((nums1.Length + nums2.Length) / 2) - 1;
            var middle2 = middle1 + 1;

            var prevValue = 0.0;

            for (var i = 0; i <= middle2; i++)
            {
                prevValue = currentValue;

                if (index1 < nums1.Length && index2 < nums2.Length)
                    currentValue = (nums1[index1] <= nums2[index2]) ? nums1[index1++] : nums2[index2++];

                else if (index1 < nums1.Length)
                    currentValue = nums1[index1++];

                else if (index2 < nums2.Length)
                    currentValue = nums2[index2++];
            }

            return (prevValue + currentValue) / 2.0;
        }
    }
}