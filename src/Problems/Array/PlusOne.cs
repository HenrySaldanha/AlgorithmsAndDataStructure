namespace Problems.Array
{
    public class PlusOne
    {
        public int[] Solution(int[] digits)
        {
            var carry = 0;
            digits[digits.Length - 1]++;

            if (digits[digits.Length - 1] < 10)
                return digits;

            var response = new int[digits.Length + 1];

            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var newCarry = (digits[i] + carry) / 10;
                digits[i] = (digits[i] + carry) % 10;
                response[i + 1] = digits[i];
                carry = newCarry;
            }

            if (carry == 0)
                return digits;

            response[0] = carry;
            return response;
        }
    }
}
