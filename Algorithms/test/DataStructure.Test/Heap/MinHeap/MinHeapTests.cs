using Xunit;

namespace DataStructure.Test.Heap.MinHeap
{
    public class MinHeapTests
    {
        [Fact]
        public void Add_ValidKey_MustAdd()
        {
            //Arrange
            var heap = new DataStructure.Heap.MinHeap.MinHeap(3);

            //Act
            heap.Add(3).Add(8).Add(1);

            //Assert
            Assert.Equal(3, heap.Size);
            Assert.Equal(1, heap.Heap[0]);
            Assert.Equal(8, heap.Heap[1]);
            Assert.Equal(3, heap.Heap[2]);
        }

        [Fact]
        public void Add_Oversize_DontAdd()
        {
            //Arrange
            var heap = new DataStructure.Heap.MinHeap.MinHeap(3);

            //Act
            heap.Add(3).Add(8).Add(1).Add(7);

            //Assert
            Assert.Equal(3, heap.Size);
            Assert.Equal(1, heap.Heap[0]);
            Assert.Equal(8, heap.Heap[1]);
            Assert.Equal(3, heap.Heap[2]);
        }

        [Fact]
        public void Remove_ValidKey_Remove()
        {
            //Arrange
            var heap = new DataStructure.Heap.MinHeap.MinHeap(5);
            heap.Add(3).Add(8).Add(1).Add(7);

            //Act
            heap.RemoveAt(2);

            //Assert
            Assert.Equal(3, heap.Size);
            Assert.Equal(1, heap.Heap[0]);
            Assert.Equal(7, heap.Heap[1]);
            Assert.Equal(8, heap.Heap[2]);
        }
    }
}
