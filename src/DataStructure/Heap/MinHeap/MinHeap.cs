namespace DataStructure.Heap.MinHeap
{
    public class MinHeap
    {
        public int Capacity { get; private set; }
        public int?[] Heap { get; private set; }
        public int Size { get; private set; }

        public MinHeap(int capacity)
        {
            Capacity = capacity;
            Heap = new int?[capacity];
            Size = 0;
        }

        public MinHeap Add(int item)
        {
            if (Size == Capacity)
                return this;

            Heap[Size] = item;

            var i = Size;
            while (i != 0 && Heap[i] < Heap[ParentIndex(i)])
            {
                Swap(ref Heap[i], ref Heap[ParentIndex(i)]);
                i = ParentIndex(i);
            }

            Size++;
            return this;
        }

        public void RemoveAt(int key)
        {
            DecreaseKey(key, int.MinValue);
            ExtractMin();
        }

        public int? GetMin() => Heap[0];

        private void MinHeapify(int key)
        {
            var left = LeftIndex(key);
            var right = RightIndex(key);
            int smallest = key;

            if (left < Size && Heap[left] < Heap[smallest])
                smallest = left;

            if (right < Size && Heap[right] < Heap[smallest])
                smallest = right;

            if (smallest != key)
            {
                Swap(ref Heap[key], ref Heap[smallest]);
                MinHeapify(smallest);
            }
        }

        private void DecreaseKey(int key, int new_val)
        {
            Heap[key] = new_val;

            while (key != 0 && Heap[key] < Heap[ParentIndex(key)])
            {
                Swap(ref Heap[key], ref Heap[ParentIndex(key)]);
                key = ParentIndex(key);
            }
        }

        private int ExtractMin()
        {
            if (Size <= 0)
                return int.MaxValue;

            if (Size == 1)
            {
                Size--;
                return Heap[0].Value;
            }

            var root = Heap[0];

            Heap[0] = Heap[Size - 1];
            Heap[Size - 1] = null;
            Size--;
            MinHeapify(0);

            return root.Value;
        }

        private static void Swap(ref int? a, ref int? b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        private int ParentIndex(int keyIndex) => (keyIndex - 1) / 2;
        private int LeftIndex(int keyIndex) => 2 * keyIndex + 1;
        private int RightIndex(int keyIndex) => 2 * keyIndex + 2;
    }
}
