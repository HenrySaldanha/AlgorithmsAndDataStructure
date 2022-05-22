namespace Search.FibonacciSearch
{
    public static class FibonacciSearch
    {
        public static bool HasValue(this int[] array, int valueSearch)
        {
            var size = array.Length;
            var fibonacciFirstValue = 0;
            var fibonacciSecondValue = 1;
            var fibonacciThirdValue = fibonacciFirstValue + fibonacciSecondValue;

            while (fibonacciThirdValue < size)
            {
                fibonacciFirstValue = fibonacciSecondValue;
                fibonacciSecondValue = fibonacciThirdValue;
                fibonacciThirdValue = fibonacciFirstValue + fibonacciSecondValue;
            }

            int rangeEliminated = -1;

            while (fibonacciThirdValue > 1)
            {
                int i = Min(rangeEliminated + fibonacciFirstValue, size - 1);

                if (array[i] == valueSearch)
                    return true;
                
                if (array[i] < valueSearch)
                {
                    fibonacciThirdValue = fibonacciSecondValue;
                    fibonacciSecondValue = fibonacciFirstValue;
                    fibonacciFirstValue = fibonacciThirdValue - fibonacciSecondValue;
                    rangeEliminated = i;
                }
                else if (array[i] > valueSearch)
                {
                    fibonacciThirdValue = fibonacciFirstValue;
                    fibonacciSecondValue = fibonacciSecondValue - fibonacciFirstValue;
                    fibonacciFirstValue = fibonacciThirdValue - fibonacciSecondValue;
                }
            }

            if (fibonacciSecondValue == 1 && array[size - 1] == valueSearch)
                return true;

            return false;
        }

        private static int Min(int a, int b) => a < b ? a : b;

    }
}
