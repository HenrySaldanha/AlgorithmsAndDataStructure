namespace Problems.Array
{
    public class PartitionEqualSubsetSum
    {
        public bool Solution(int[] nums)
        {
            var totalSum = nums.Sum();
            if(totalSum % 2 != 0) return false;

            return HasSumSubGroup(nums, 0, 0, totalSum, new Dictionary<string, bool>());
        }

        public bool HasSumSubGroup(int[] nums, int index, int sum, int total, Dictionary<string, bool> dict)
        {
            if (dict.ContainsKey($"{index}{sum}"))
                return dict[$"{index}{sum}"];

            if (sum * 2 == total)
                return true;

            if(sum*2 > total || index >= nums.Length) 
                return false;

            var hasSum = HasSumSubGroup(nums, index+1, sum + nums[index], total, dict) || HasSumSubGroup(nums, index + 1, sum , total, dict);

            dict[$"{index}{sum}"] = hasSum;

            return hasSum;
        }
    }
}
