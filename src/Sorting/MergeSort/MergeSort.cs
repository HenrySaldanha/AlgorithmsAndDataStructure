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
            var leftArray = new int[middle - iniIndex + 1];
            var rightArray = new int[endIndex - middle];

            for (int i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[iniIndex + i];

            for (int j = 0; j < rightArray.Length; j++)
                rightArray[j] = array[middle + j + 1];

            var leftIndex = 0;
            var rightIndex = 0;
            var arrayIndex = iniIndex;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if ((leftArray[leftIndex] < rightArray[rightIndex] && asc) ||
                    (leftArray[leftIndex] > rightArray[rightIndex] && !asc))
                {
                    array[arrayIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                arrayIndex++;
            }

            while (leftIndex < leftArray.Length)
            {
                array[arrayIndex] = leftArray[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            while (rightIndex < rightArray.Length)
            {
                array[arrayIndex] = rightArray[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
        }
    }
}
