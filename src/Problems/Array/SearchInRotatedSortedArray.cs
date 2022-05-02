namespace Problems.Array
{
    public class SearchInRotatedSortedArray
    {
        public int SolutionA(int[] nums, int target)
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
}
