namespace Sorting.RadixSort;
public static class RadixSort
{
    public static void Order(this int[] array)
    {
        if (array.Length == 0)
            return;

        var output = new int[array.Length];
        var exp = 1;

        var max = GetMax(array);

        while (max / exp > 0)
        {
            var count = new int[10];

            for (var i = 0; i < array.Length; i++)
                count[(array[i] / exp) % 10]++;

            for (var i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (var i = array.Length - 1; i >= 0; i--)
                output[--count[(array[i] / exp) % 10]] = array[i];

            for (var i = 0; i < array.Length; i++)
                array[i] = output[i];

            exp *= 10;
        }

    }

    public static void OrderDesc(this int[] array)
    {
        if (array.Length == 0)
            return;

        var output = new int[array.Length];
        var exp = 1;

        var max = GetMax(array);

        while (max / exp > 0)
        {
            var count = new int[10];

            for (var i = 0; i < array.Length; i++)
                count[9 - ((array[i] / exp) % 10)]++;

            for (var i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (var i = array.Length - 1; i >= 0; i--)
                output[--count[9 - ((array[i] / exp) % 10)]] = array[i];

            for (var i = 0; i < array.Length; i++)
                array[i] = output[i];

            exp *= 10;
        }

    }

    private static int GetMax(int[] array)
    {
        var max = array[0];

        for (var i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}