namespace Sorting.CountingSort;
public static class CountingSort
{
    public static void Order(this int[] array)
    {
        if (array is null || array.Length <= 1)
            return;

        var output = new int[array.Length];

        var max = array.Max();
        var count = new int[max + 1];

        for (var i = 0; i < array.Length; i++)
            count[array[i]]++;

        for (var i = 1; i <= max; ++i)
            count[i] += count[i - 1];

        for (var i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        for (var i = 0; i < array.Length; i++)
            array[i] = output[i];
    }

    public static void OrderDesc(this int[] array)
    {
        if (array is null || array.Length <= 1)
            return;

        var output = new int[array.Length];

        var max = array.Max();
        var count = new int[max + 1];

        for (var i = 0; i < array.Length; i++)
            count[array[i]]++;

        for (var i = 1; i <= max; ++i)
            count[i] += count[i - 1];

        for (var i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        for (var i = 0; i < array.Length; i++)
            array[array.Length - i - 1] = output[i];
    }
}