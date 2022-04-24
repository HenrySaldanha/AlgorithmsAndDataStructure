using Algorithms.DataStructure.Array;
using Xunit;

namespace DataStructure.Array.Test
{
    public class SimpleArrayTests
    {
        [Fact]
        public void Add_ValidKey_MustAdd()
        {
            //Arrange
            var array = new SimpleArray<int>();

            //Act
            array.Add(4).Add(1123).Add(456);

            //Assert
            Assert.Equal(3, array.Size);
        }

        [Fact]
        public void Add_NullKey_DontAdd()
        {
            //Arrange
            var array = new SimpleArray<int?>();

            //Act
            array.Add(4).Add(1123).Add(null);

            //Assert
            Assert.Equal(2, array.Size);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(1123)]
        [InlineData(456)]
        public void Remove_ValidKey_MustRemove(int key)
        {
            //Arrange
            var array = new SimpleArray<int>();
            array.Add(4).Add(1123).Add(456);

            //Act
            array.Remove(key);

            //Assert
            Assert.Equal(2, array.Size);
        }

        [Fact]
        public void Remove_ArrayNull_DontRemove()
        {
            //Arrange
            var array = new SimpleArray<int>();

            //Act
            array.Remove(133);

            //Assert
            Assert.Equal(0, array.Size);
        }

        [Fact]
        public void Remove_InvalidKey_DontRemove()
        {
            //Arrange
            var array = new SimpleArray<int>();
            array.Add(4).Add(1123).Add(456);

            //Act
            array.Remove(1);

            //Assert
            Assert.Equal(3, array.Size);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void RemoveAt_ValidIndex_MustRemove(int index)
        {
            //Arrange
            var array = new SimpleArray<int>();
            array.Add(4).Add(1123).Add(456);

            //Act
            array.RemoveAt(index);

            //Assert
            Assert.Equal(2, array.Size);
        }

        [Fact]
        public void RemoveAt_ArrayNull_DontRemove()
        {
            //Arrange
            var array = new SimpleArray<int>();

            //Act
            array.RemoveAt(0);

            //Assert
            Assert.Equal(0, array.Size);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(5)]
        public void RemoveAt_InvalidIndex_DontRemove(int index)
        {
            //Arrange
            var array = new SimpleArray<int>();
            array.Add(4).Add(1123).Add(456);

            //Act
            array.RemoveAt(index);

            //Assert
            Assert.Equal(3, array.Size);
        }
    }
}