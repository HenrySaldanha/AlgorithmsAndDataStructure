namespace Sorting.SelectionSort
{
    public static class SelectionSort
    {
        public static void Order(this int[] array, int iniIndex = 0)
        {
            if (array is null || array.Length <= 1 || iniIndex >= array.Length - 1)
                return;

            var minValueIndex = iniIndex;

            for (var i = iniIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minValueIndex])
                    minValueIndex = i;
            }

            var swap = array[minValueIndex];
            array[minValueIndex] = array[iniIndex];
            array[iniIndex] = swap;

            Order(array, iniIndex + 1);
        }

        public static void OrderDesc(this int[] array, int iniIndex = 0)
        {
            if (array is null || array.Length <= 1 || iniIndex >= array.Length - 1) return;

            var maxValueIndex = iniIndex;

            for (var i = iniIndex + 1; i < array.Length; i++)
            {
                if (array[i] > array[maxValueIndex])
                    maxValueIndex = i;
            }

            var swap = array[maxValueIndex];
            array[maxValueIndex] = array[iniIndex];
            array[iniIndex] = swap;

            OrderDesc(array, iniIndex + 1);
        }
    }
}
