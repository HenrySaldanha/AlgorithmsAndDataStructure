namespace Algorithms.Search.BinarySearch
{
    public static class BinarySearch
    {
        public static bool Exists(this int[] array, int itemValue, int? ini=null, int? end = null)
        {
           ini ??= 0;
           end ??= array.Length - 1;

            if (ini == end)
                return array[ini.Value] == itemValue;
            
            var middle = ini + ((end - ini) / 2);

            if (array[middle.Value] == itemValue)
                return true;

            if (array[middle.Value] > itemValue)
               return Exists(array, itemValue, ini, middle-1);
            else
                return Exists(array, itemValue, middle+1, end);

        }


    }
}
