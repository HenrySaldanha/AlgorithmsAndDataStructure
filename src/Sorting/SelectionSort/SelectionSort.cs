namespace Sorting.SelectionSort;
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

        (array[minValueIndex], array[iniIndex]) = (array[iniIndex], array[minValueIndex]);

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

        (array[maxValueIndex], array[iniIndex]) = (array[iniIndex], array[maxValueIndex]);

        OrderDesc(array, iniIndex + 1);
    }
}