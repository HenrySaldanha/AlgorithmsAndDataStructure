namespace Problems.Sorting;

/// <summary>
/// Given two integer arrays nums1 and nums2, return an array of their intersection. 
/// Each element in the result must be unique and you may return the result in any order.
/// </summary>

/// <example>
/// Input: nums1 = [1,2,2,1], nums2 = [2,2]
/// Output: [2]
/// </example>

/// <example>
/// Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
/// Output: [9,4] or [4,9]
/// </example>

public class IntersectionOfTwoArrays
{
    public int[] SolutionA(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }

    public int[] SolutionB(int[] nums1, int[] nums2)
    {
        var result = new List<int>();

        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        var i = 0;
        var j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
            else if (nums2[j] < nums1[i])
            {
                j++;
            }
            else
            {
                i++;
            }
        }

        return result.Distinct().ToArray();
    }

    public int[] SolutionC(int[] nums1, int[] nums2)
    {
        var nums1Hash = new HashSet<int>();
        var response = new HashSet<int>();

        for (var i = 0; i < nums1.Length; i++)
            nums1Hash.Add(nums1[i]);

        for (var i = 0; i < nums2.Length; i++)
        {
            if (nums1Hash.Contains(nums2[i]))
                response.Add(nums2[i]);
        }
        return response.ToArray();
    }
}