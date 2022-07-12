namespace Search.InterpolationSearch;
public static class InterpolationSearch
{
    public static bool HasValue(this int[] array, int valueSearch)
    {
        var rightIndex = array.Length - 1;
        var leftIndex = 0;

        while (valueSearch >= array[leftIndex] && 
               valueSearch <= array[rightIndex] && 
               leftIndex <= rightIndex)
        {
            var probe = leftIndex + (rightIndex - leftIndex) * (valueSearch - array[leftIndex]) / (array[rightIndex] - array[leftIndex]);

            if (rightIndex == leftIndex)
                return array[leftIndex] == valueSearch;

            if (array[probe] == valueSearch)
                return true;

            if (array[probe] < valueSearch)
                leftIndex = probe + 1;
            else
                rightIndex = probe - 1;
        }
        return false;
    }

}