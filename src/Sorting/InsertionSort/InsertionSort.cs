namespace Sorting.InsertionSort;
public static class InsertionSort
{
    public static void OrderDesc(this int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i - 1;
            while (j >= 0 && key > array[j])
            {
                array[j + 1] = array[j];
                j--;
            }
            j++;
            array[j] = key;
        }
    }

    public static void Order(this int[] array)
    {
        for (var i = 1; i < array.Length; i++)
        {
            var key = array[i];
            var j = i - 1;
            while (j >= 0 && key < array[j])
            {
                array[j + 1] = array[j];
                j--;
            }
            j++;
            array[j] = key;
        }
    }
}