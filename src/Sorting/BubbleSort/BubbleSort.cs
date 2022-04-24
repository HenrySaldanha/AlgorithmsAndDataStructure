namespace Sorting.BubbleSort
{
    public static class BubbleSort
    {
        public static void Order(this int[] array, int? n = null)
        {
            if (n <= 1)
                return;

            if (n is null)
                n = array.Length;

            var swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (array[i] < array[i - 1])
                {
                    var swap = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = swap;
                    swapped = true;
                }
            }

            if (!swapped)
                return;

            Order(array, n - 1);
        }

        public static void OrderDesc(this int[] array, int? n = null)
        {
            if (n <= 1)
                return;

            if (n is null)
                n = array.Length;

            var swapped = false;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[i - 1])
                {
                    var swap = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = swap;
                    swapped = true;
                }
            }

            if (!swapped)
                return;

            OrderDesc(array, n - 1);
        }
    }
}
