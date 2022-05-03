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

        private static void MergeSortOrder(int[] array, int iniIndex, int endIndex, bool asc)
        {
            if (iniIndex < endIndex)
            {
                var middle = (iniIndex + endIndex) / 2;
                MergeSortOrder(array, iniIndex, middle, asc);
                MergeSortOrder(array, middle + 1, endIndex, asc);
                Merge(array, iniIndex, middle, endIndex, asc);
            }
        }

        private static void Merge(int[] array, int iniIndex, int middle, int endIndex, bool asc)
        {
            var left_array = new int[middle - iniIndex + 1];
            var right_array = new int[endIndex - middle];

            for (int i = 0; i < left_array.Length; i++)
                left_array[i] = array[iniIndex + i];

            for (int j = 0; j < right_array.Length; j++)
                right_array[j] = array[middle + j + 1];

            var leftIndex = 0;
            var rightIndex = 0;
            var arrayIndex = iniIndex;

            while (leftIndex < left_array.Length && rightIndex < right_array.Length)
            {
                if ((left_array[leftIndex] < right_array[rightIndex] && asc) ||
                    (left_array[leftIndex] > right_array[rightIndex] && !asc))
                {
                    array[arrayIndex] = left_array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = right_array[rightIndex];
                    rightIndex++;
                }

                arrayIndex++;
            }

            while (leftIndex < left_array.Length)
            {
                array[arrayIndex] = left_array[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            while (rightIndex < right_array.Length)
            {
                array[arrayIndex] = right_array[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
        }
    }
}
