using Search.FibonacciSearch;
using Xunit;

namespace Search.Test.FibonacciSearch
{
    public class FibonacciSearchTests
    {
        [Theory]
        [InlineData(-10)]
        [InlineData(3)]
        [InlineData(44567)]
        public void HasValue_ValidKey_MustExists(int key)
        {
            //Arrange
            var array = new int[] { -10, 1, 2, 3, 4, 5, 123, 1234, 2345, 4567, 12331, 44567 };

            //Act
            var result = array.HasValue(key);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(-50)]
        [InlineData(10)]
        [InlineData(60000)]
        public void Exists_InvalidKey_MustNotExists(int key)
        {
            //Arrange
            var array = new int[] { -10, 1, 2, 3, 4, 5, 123, 1234, 2345, 4567, 12331, 44567 };

            //Act
            var result = array.HasValue(key);

            //Assert
            Assert.False(result);
        }
    }
}
