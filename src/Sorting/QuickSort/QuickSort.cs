namespace Sorting.QuickSort;
public static class QuickSort
{
    public static void Order(this int[] array, int ini = 0, int? end = null)
    {
        if (array is null || array.Length <= 1 || ini > end)
            return;

        end ??= array.Length - 1;

        var pivot = array[(ini + end.Value) / 2];
        var iniIndex = ini;
        var endIndex = end.Value;

        while (iniIndex <= endIndex)
        {
            if (array[iniIndex] <= pivot)
            {
                iniIndex++;
            }
            else if (array[endIndex] > pivot)
            {
                endIndex--;
            }
            else
            {
                (array[endIndex], array[iniIndex]) = (array[iniIndex], array[endIndex]);

                iniIndex++;
                endIndex--;
            }
        }

        array[ini] = array[endIndex];
        array[endIndex] = pivot;

        Order(array, ini, endIndex - 1);
        Order(array, endIndex + 1, end);
    }

    public static void OrderDesc(this int[] array, int ini = 0, int? end = null)
    {
        if (array is null || array.Length <= 1 || ini > end)
            return;

        if (end is null)
            end = array.Length - 1;

        var pivot = array[(ini + end.Value) / 2];
        var iniIndex = ini;
        var endIndex = end.Value;

        while (iniIndex <= endIndex)
        {
            if (array[iniIndex] >= pivot)
            {
                iniIndex++;
            }
            else if (array[endIndex] < pivot)
            {
                endIndex--;
            }
            else
            {
                (array[endIndex], array[iniIndex]) = (array[iniIndex], array[endIndex]);
                iniIndex++;
                endIndex--;
            }
        }

        array[ini] = array[endIndex];
        array[endIndex] = pivot;

        OrderDesc(array, ini, endIndex - 1);
        OrderDesc(array, endIndex + 1, end);
    }
}