namespace Problems.Array;

/// <summary>
/// Given two integer arrays nums1 and nums2, return an array of their intersection. 
/// Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
/// </summary>

/// <example>
/// Input: nums1 = [1,2,2,1], nums2 = [2,2]
/// Output: [2,2]
/// </example>

public class IntersectionOfTwoArraysII
{
    public int[] SolutionA(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();
        var result = new List<int>();

        for (var i = 0; i < nums1.Length; i++)
        {
            if (!dict.ContainsKey(nums1[i]))
                dict[nums1[i]] = 1;
            else
                dict[nums1[i]]++;
        }

        for (var i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                dict[nums2[i]]--;
            }
        }

        return result.ToArray();
    }

    public int[] SolutionB(int[] nums1, int[] nums2)
    {
        var numbers = new int[1001];
        var result = new List<int>();

        for (var i = 0; i < nums1.Length; i++)
            numbers[nums1[i]]++;

        for (var i = 0; i < nums2.Length; i++)
        {
            if (numbers[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                numbers[nums2[i]]--;
            }
        }

        return result.ToArray();
    }
}