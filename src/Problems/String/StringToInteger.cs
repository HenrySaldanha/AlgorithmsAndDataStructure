namespace Problems.String
{
    public class StringToInteger
    {
        public int Solution(string s)
        {
            var i = 0;
            long number = 0;
            bool positive = true;


            while (i < s.Length && s[i] == ' ')
                i++;

            if (i < s.Length && s[i] == '-')
            {
                positive = false;
                i++;
            }
            else if (i < s.Length && s[i] == '+')
            {
                positive = true;
                i++;
            }

            while (i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                number *= 10;
                number += s[i] - '0';

                if (positive && number > Int32.MaxValue)
                    return Int32.MaxValue;
                if (!positive && number > Int32.MaxValue)
                    return Int32.MinValue;

                i++;
            }

            return positive ? (int)number : (int)number * -1;
        }
    }
}
