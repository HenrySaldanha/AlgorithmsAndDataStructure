namespace Problems.Array;

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

            if (dict.ContainsKey(complement))
                return new[] { dict[complement], i };

            dict[nums[i]] = i;

        }
        return new[] { -1, -1 };
    }


    public int[] SolutionB(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 1; j < nums.Length; j++)
            {
                if (j == i)
                    continue;

                if (nums[i] + nums[j] == target)
                    return new[] { i, j };

            }
        }

        return new[] { -1, -1 };
    }

    public int[] SolutionC(int[] nums, int target)
    {
        int i1 = 0, j1 = 0;

        System.Threading.Tasks.Parallel.For(0, nums.Length, (i, stateI) =>
        {
            System.Threading.Tasks.Parallel.For(1, nums.Length, (j, stateJ) =>
            {
                if (nums[i] + nums[j] == target && j != i)
                {
                    i1 = i;
                    j1 = j;
                    stateI.Break();
                    stateJ.Break();
                }
            });
        });

        return j1 < i1 ? new[] { j1, i1 } : new[] { i1, j1 };
    }
}