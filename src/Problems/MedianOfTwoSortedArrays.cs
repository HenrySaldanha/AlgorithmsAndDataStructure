namespace Problems
{
    public class MedianOfTwoSortedArrays
    {
        public double SolutionA(int[] nums1, int[] nums2)
        {
            var index1 = 0;
            var index2 = 0;

            var current_value = 0.0;

            if (((nums1.Length + nums2.Length) % 2 != 0))
            {
                var middle = (nums1.Length + nums2.Length - 1) / 2;

                for (var i = 0; i <= middle; i++)
                {
                    if (index1 < nums1.Length && index2 < nums2.Length)
                        current_value = (nums1[index1] <= nums2[index2]) ? nums1[index1++] : nums2[index2++];

                    else if (index1 < nums1.Length)
                        current_value = nums1[index1++];

                    else if (index2 < nums2.Length)
                        current_value = nums2[index2++];
                }
                return current_value;
            }
            else
            {
                var middle1 = ((nums1.Length + nums2.Length) / 2) - 1;
                var middle2 = middle1 + 1;

                var prev_value = 0.0;

                for (var i = 0; i <= middle2; i++)
                {
                    prev_value = current_value;

                    if (index1 < nums1.Length && index2 < nums2.Length)
                        current_value = (nums1[index1] <= nums2[index2]) ? nums1[index1++] : nums2[index2++];

                    else if (index1 < nums1.Length)
                        current_value = nums1[index1++];

                    else if (index2 < nums2.Length)
                        current_value = nums2[index2++];
                }

                return (prev_value + current_value) / 2.0;
            }
        }
    }
}
