namespace Sorting.QuickSort
{
    public static class QuickSort
    {
        public static void Order(this int[] array, int ini = 0, int? end = null)
        {
            if (array == null || array.Length <= 1 || ini > end) return;

            if (end == null)
                end = array.Length - 1;

            var pivot = array[ini];
            var ini_index = ini + 1;
            var end_index = end.Value;

            while (ini_index <= end_index)
            {
                if (array[ini_index] <= pivot)
                    ini_index++;
                else if (array[end_index] > pivot)
                    end_index--;
                else
                {
                    var swap = array[end_index];
                    array[end_index] = array[ini_index];
                    array[ini_index] = swap;
                    ini_index++;
                    end_index--;
                }
            }

            array[ini] = array[end_index];
            array[end_index] = pivot;

            Order(array, ini, end_index - 1);
            Order(array, end_index + 1, end);
        }

        public static void OrderDesc(this int[] array, int ini = 0, int? end = null)
        {
            if (array == null || array.Length <= 1 || ini > end) return;

            if (end == null)
                end = array.Length - 1;

            var pivot = array[ini];
            var ini_index = ini + 1;
            var end_index = end.Value;

            while (ini_index <= end_index)
            {
                if (array[ini_index] >= pivot)
                    ini_index++;
                else if (array[end_index] < pivot)
                    end_index--;
                else
                {
                    var swap = array[end_index];
                    array[end_index] = array[ini_index];
                    array[ini_index] = swap;
                    ini_index++;
                    end_index--;
                }
            }

            array[ini] = array[end_index];
            array[end_index] = pivot;

            OrderDesc(array, ini, end_index - 1);
            OrderDesc(array, end_index + 1, end);
        }

    }
}
