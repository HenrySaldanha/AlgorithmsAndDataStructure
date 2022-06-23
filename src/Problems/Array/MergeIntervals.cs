namespace Problems.Array;

    /// <summary>
    /// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, 
    /// and return an array of the non-overlapping intervals that cover all the intervals in the input.
    /// </summary>

    /// <example>
    /// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
    /// Output: [[1,6],[8,10],[15,18]]
    /// Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].
    /// </example>

    public class MergeIntervals
    {
        public int[][] Solution(int[][] intervals)
        {
            var response = new List<int[]>();

            System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            for (var i = 0; i < intervals.Length; i++)
            {
                if (!response.Any() || response[response.Count - 1][1] < intervals[i][0])
                    response.Add(intervals[i]);
                else
                    response[response.Count - 1][1] = System.Math.Max(response[response.Count - 1][1], intervals[i][1]);
            }

            return response.ToArray();
        }
    }