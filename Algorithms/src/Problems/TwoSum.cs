using System.Collections.Generic;

namespace Problems
{

    ///<summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    ///</summary>

    ///<example>
    ///Input: nums = [2,7,11,15], target = 9
    ///Output: [0,1]
    ///</example>

    ///<example>
    ///Input: nums = [3,3], target = 6
    ///Output: [0,1]
    ///</example>

    public class TwoSum
    {
        public int[] SolutionA(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dict.TryGetValue(complement, out var res) && res != i)
                {
                    return i < res ? new[] { i, res } : new[] { res, i };
                }

                dict[nums[i]] = i;

            }
            return new int[] { -1, -1 };
        }

        public int[] SolutionB(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                        continue;

                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };

                }
            }

            return new int[] { -1, -1 };
        }


    }
}
