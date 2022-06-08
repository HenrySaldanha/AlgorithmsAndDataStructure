namespace Problems.Sorting
{
    /// <summary>
    /// You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition.
    /// All the scores are guaranteed to be unique.
    /// The athletes are placed based on their scores, where the 1st place athlete has the highest score,
    /// the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:
    /// 
    /// The 1st place athlete's rank is "Gold Medal".
    /// The 2nd place athlete's rank is "Silver Medal".
    /// The 3rd place athlete's rank is "Bronze Medal".
    /// For the 4th place to the nth place athlete, their rank is their placement 
    /// number(i.e., the xth place athlete's rank is "x").
    /// </summary>

    /// <example>
    /// Input: score = [5,4,3,2,1]
    /// Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"]
    /// Explanation: The placements are [1st, 2nd, 3rd, 4th, 5th].
    /// </example>

    public class RelativeRanks
    {
        public string[] Solution(int[] score)
        {
            var ret = new string[score.Length];
            int[] numsCopy = (int[])score.Clone();

            System.Array.Sort(numsCopy);

            var al = numsCopy.ToList();
            for (int i = score.Length - 1; i >= 0; i--)
                al.Add(numsCopy[i]);

            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] == numsCopy[score.Length - 1])
                    ret[i] = "Gold Medal";
                else if (score[i] == numsCopy[score.Length - 2])
                    ret[i] = "Silver Medal";
                else if (score[i] == numsCopy[score.Length - 3])
                    ret[i] = "Bronze Medal";
                else 
                    ret[i] = (al.IndexOf(score[i]) + 1).ToString();
            }
            return ret;
        }
    }
}
