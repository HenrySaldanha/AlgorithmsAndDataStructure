namespace Problems.Array;

/// <summary>
/// You are given an integer array height of length n. There are n vertical lines drawn 
/// such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
/// Find two lines that together with the x-axis form a container, such that the container contains the most water.
/// Return the maximum amount of water a container can store.
/// </summary>

/// <example>
/// Input: height = [1,8,6,2,5,4,8,3,7]
/// Output: 49
/// Explanation: Explanation: The heights are [8,7] and the length is 7. 
/// We need to take the smallest height and multiply by the length, so 7*7 = 49
/// </example>

public class ContainerWithMostWater
{
    public int Solution(int[] height)
    {
        var ini = 0;
        var end = height.Length - 1;
        var area = 0;

        while (ini < end)
        {
            if (height[ini] < height[end])
            {
                area = Max(area, height[ini] * (end - ini));
                ini++;
            }
            else
            {
                area = Max(area, height[end] * (end - ini));
                end--;
            }
        }

        return area;
    }
    private int Max(int a, int b) => a > b ? a : b;
}