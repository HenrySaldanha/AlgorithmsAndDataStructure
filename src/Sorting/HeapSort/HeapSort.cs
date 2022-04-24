using DataStructure.Heap.MinHeap;

namespace Sorting.HeapSort
{
    public static class HeapSort
    {
        public static void Order(this int[] array)
        {
            if (array is null || array.Length <= 1)
                return;

            var heap = new MinHeap(array.Length);

            foreach (var item in array)
                heap.Add(item);

            for (var i = 0; i < array.Length; i++)
            {
                var minHeap = heap.GetMin();
                if (minHeap is not null)
                {
                    array[i] = minHeap.Value;
                    heap.RemoveAt(0);
                }
            }
        }

        public static void OrderDesc(this int[] array)
        {
            if (array is null || array.Length <= 1)
                return;

            var heap = new MinHeap(array.Length);

            foreach (var item in array)
                heap.Add(item);

            for (var i = array.Length - 1; i >= 0; i--)
            {
                var minHeap = heap.GetMin();
                if (minHeap is not null)
                {
                    array[i] = minHeap.Value;
                    heap.RemoveAt(0);
                }
            }
        }

    }
}