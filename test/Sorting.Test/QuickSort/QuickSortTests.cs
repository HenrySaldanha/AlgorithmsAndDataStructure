using Sorting.QuickSort;

namespace Sorting.Test.QuickSort
{
    public class QuickSortTests
    {
        [Fact]
        public void Order_ClutteredData_OrderData()
        {
            //Arrange
            var array = new int[] { 663, 200, 0, 10, 17, 5, 1, 4, -1, 530, 221, 12, 33, 1540, -230 };

            //Act
            array.Order();

            //Assert
            Assert.Equal(array.Min(), array[0]);
            Assert.True(array[0] < array[1]);
            Assert.True(array[array.Length - 2] < array[array.Length - 1]);
            Assert.Equal(array.Max(), array[array.Length - 1]);
        }

        [Fact]
        public void Order_SortedData_MustKeepOrderly()
        {
            //Arrange
            var array = new int[] { -230, -1, 0, 1, 4, 5, 10, 12, 17, 33, 200, 221, 530, 663, 1540 };

            //Act
            array.Order();

            //Assert
            Assert.Equal(array.Min(), array[0]);
            Assert.True(array[0] < array[1]);
            Assert.True(array[array.Length - 2] < array[array.Length - 1]);
            Assert.Equal(array.Max(), array[array.Length - 1]);
        }

        [Fact]
        public void Order_EmptyArray_ReturnArray()
        {
            //Arrange
            var array = new int[] { };

            //Act
            array.Order();

            //Assert
            Assert.Empty(array);
        }

        [Fact]
        public void OrderDesc_ClutteredData_OrderData()
        {
            //Arrange
            var array = new int[] { 663, 200, 0, 10, 17, 5, 1, 4, -1, 530, 221, 12, 33, 1540, -230 };

            //Act 
            array.OrderDesc();

            //Assert
            Assert.Equal(array.Max(), array[0]);
            Assert.True(array[0] > array[1]);
            Assert.True(array[array.Length - 2] > array[array.Length - 1]);
            Assert.Equal(array.Min(), array[array.Length - 1]);
        }

        [Fact]
        public void OrderDesc_SortedData_MustKeepOrderly()
        {
            //Arrange
            var array = new int[] { 1540, 663, 530, 221, 200, 33, 17, 12, 10, 5, 4, 1, 0, -1, -230 };

            //Act
            array.OrderDesc();

            //Assert
            Assert.Equal(array.Max(), array[0]);
            Assert.True(array[0] > array[1]);
            Assert.True(array[array.Length - 2] > array[array.Length - 1]);
            Assert.Equal(array.Min(), array[array.Length - 1]);
        }

        [Fact]
        public void OrderDesc_EmptyArray_ReturnArray()
        {
            //Arrange
            var array = new int[] { };

            //Act
            array.OrderDesc();

            //Assert
            Assert.Empty(array);
        }
    }
}
