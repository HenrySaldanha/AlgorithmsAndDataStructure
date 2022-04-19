using Algorithms.DataStructure.List.DoublyLinkedList;
using Xunit;

namespace DataStructure.Test.List.DoublyLinkedList
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void Add_ValidKey_MustAdd()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();

            //Act
            list.Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(8)).Add(new DoublyNode<int>(-2));

            //Assert
            Assert.Equal(3, list.Size);
            Assert.Equal(-2, list.FirstNode.NextNode.NextNode.Key);
            Assert.Equal(8, list.FirstNode.NextNode.Key);
            Assert.Equal(8, list.FirstNode.NextNode.NextNode.LastNode.Key);
            Assert.Equal(3, list.FirstNode.Key);
            Assert.Equal(3, list.FirstNode.NextNode.LastNode.Key);
        }

        [Fact]
        public void Add_NullKey_DontAdd()
        {
            //Arrange
            var list = new DoublyLinkedList<int?>();

            //Act
            list.Add(new DoublyNode<int?>(3)).Add(null).Add(new DoublyNode<int?>(null));

            //Assert
            Assert.Equal(1, list.Size);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(8)]
        [InlineData(-2)]
        public void Remove_ValidKey_MustRemove(int key)
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(8)).Add(new DoublyNode<int>(-2));

            //Act
            list.Remove(key);

            //Assert
            Assert.Equal(2, list.Size);
        }

        [Fact]
        public void Remove_ArrayNull_DontRemove()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();

            //Act
            list.Remove(133);

            //Assert
            Assert.Equal(0, list.Size);
        }

        [Fact]
        public void Remove_InvalidKey_DontRemove()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(8)).Add(new DoublyNode<int>(-2));

            //Act
            list.Remove(1);

            //Assert
            Assert.Equal(3, list.Size);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void RemoveAt_ValidIndex_MustRemove(int index)
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(8)).Add(new DoublyNode<int>(-2));

            //Act
            list.RemoveAt(index);

            //Assert
            Assert.Equal(2, list.Size);
        }

        [Fact]
        public void RemoveAt_ArrayNull_DontRemove()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();

            //Act
            list.RemoveAt(0);

            //Assert
            Assert.Equal(0, list.Size);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(5)]
        public void RemoveAt_InvalidIndex_DontRemove(int index)
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(8)).Add(new DoublyNode<int>(-2));

            //Act
            list.RemoveAt(index);

            //Assert
            Assert.Equal(3, list.Size);
        }
    }
}
