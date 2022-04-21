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

            for (int i = Size; i >= 0 && Heap[i] < Heap[ParentIndex(i)]; i--)
            {
                var temp = Heap[i];
                Heap[i] = Heap[ParentIndex(i)];
                Heap[ParentIndex(i)] = temp;

                i = ParentIndex(i);

            }

            Size++;
            return this;
        }

        private int ParentIndex(int key) => (key - 1) / 2;
    }
}
