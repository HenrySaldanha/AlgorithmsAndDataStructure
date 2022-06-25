namespace Problems.Test.Sorting;

public class MergeSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3)]
    [InlineData(new[] { 1, 2 }, 2, null, 0)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] numbers1, int n, int[]? numbers2, int m)
    {
        //Arrange
        var solution = new MergeSortedArray();

        //Act
        solution.Solution(numbers1, n, numbers2 ?? System.Array.Empty<int>(), m);

        //Assert
        Assert.Equal(numbers1.Min(), numbers1[0]);
        Assert.True(numbers1[0] < numbers1[1]);
        Assert.True(numbers1[numbers1.Length - 2] < numbers1[numbers1.Length - 1]);
        Assert.Equal(numbers1.Max(), numbers1[numbers1.Length - 1]);
    }
}