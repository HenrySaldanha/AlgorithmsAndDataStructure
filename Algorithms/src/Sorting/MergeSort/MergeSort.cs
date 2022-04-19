namespace Sorting.MergeSort
{
    public static class MergeSort
    {
        public static void Order(this int[] array)
        {
            MergeSortOrder(array, 0, array.Length - 1, true);
        }

        public static void OrderDesc(this int[] array)
        {
            MergeSortOrder(array, 0, array.Length - 1, false);
        }

        private static void MergeSortOrder(int[] array, int ini_index, int end_index, bool asc)
        {
            if (ini_index < end_index)
            {
                var middle = (ini_index + end_index) / 2;
                MergeSortOrder(array, ini_index, middle, asc);
                MergeSortOrder(array, middle + 1, end_index, asc);
                Merge(array, ini_index, middle, end_index, asc);
            }

        }

        private static void Merge(int[] array, int ini_index, int middle, int end_index, bool asc)
        {
            var left_array = new int[middle - ini_index + 1];
            var right_array = new int[end_index - middle];

            for (int i = 0; i < left_array.Length; i++)
                left_array[i] = array[ini_index + i];

            for (int j = 0; j < right_array.Length; j++)
                right_array[j] = array[middle + j + 1];


            var left_index = 0;
            var right_index = 0;
            var array_index = ini_index;

            while (left_index < left_array.Length && right_index < right_array.Length)
            {
                if ((left_array[left_index] < right_array[right_index] && asc) ||
                    (left_array[left_index] > right_array[right_index] && !asc))
                {
                    array[array_index] = left_array[left_index];
                    left_index++;
                }
                else
                {
                    array[array_index] = right_array[right_index];
                    right_index++;
                }

                array_index++;
            }

            while (left_index < left_array.Length)
            {
                array[array_index] = left_array[left_index];
                left_index++;
                array_index++;
            }

            while (right_index < right_array.Length)
            {
                array[array_index] = right_array[right_index];
                right_index++;
                array_index++;
            }
        }
    }
}
