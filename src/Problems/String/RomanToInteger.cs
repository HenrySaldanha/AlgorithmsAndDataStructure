namespace Problems.String
{
    public class RomanToInteger
    {
        private Dictionary<char, int> RomanNumbers { get; set; }

        public int SolutionA(string s)
        {
            var sum = 0;
            RomanNumbers = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };

            for (var i = 0; i < s.Length; i++)
            {
                var actualValue = RomanNumbers[s[i]];

                if (IsSubtraction(s, i))
                    sum -= actualValue;
                else
                    sum += actualValue;
            }

            return sum;
        }
        private bool IsSubtraction(string s, int i)
        {
            if (i + 1 >= s.Length)
                return false;

            return RomanNumbers[s[i]] < RomanNumbers[s[i + 1]];
        }
    }
}
