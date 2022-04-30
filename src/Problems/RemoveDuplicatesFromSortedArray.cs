namespace Problems
{
    /// <summary>
    /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that 
    /// each unique element appears only once. The relative order of the elements should be kept the same.
    /// </summary>

    /// <example>
    /// Input: nums = [1,1,2]
    /// Output: 2, nums = [1,2,_]
    /// Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
    /// </example>
   
    public class RemoveDuplicatesFromSortedArray
    {
        public int SolutionA(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            var k = nums.Length;

            for (var i = 1; i < k; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    k--;
                    for (int j = i; j < k; j++)
                        nums[j] = nums[j + 1];

                    i--;
                }
            }

            return k;
        }

        public int SolutionB(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            var x = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[x - 1])
                {
                    nums[x] = nums[i];
                    x++;
                }
            }

            return x;
        }
    }
}
