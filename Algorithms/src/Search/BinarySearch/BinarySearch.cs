namespace Algorithms.Search.BinarySearch
{
    public static class BinarySearch
    {
        public static bool HasValue(this int[] array, int itemValue, int? ini = null, int? end = null)
        {
            ini ??= 0;
            end ??= array.Length - 1;

            if (ini > end)
                return false;

            var middle = ini + ((end - ini) / 2);

            if (array[middle.Value] == itemValue)
                return true;
            else if (array[middle.Value] > itemValue)
                return HasValue(array, itemValue, ini, middle - 1);
            else
                return HasValue(array, itemValue, middle + 1, end);
        }
    }
}
