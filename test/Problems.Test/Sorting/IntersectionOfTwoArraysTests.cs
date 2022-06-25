namespace Problems.Test.Sorting;

public class IntersectionOfTwoArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [InlineData(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
    public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] nums1, int[] nums2, int[] expectedResponse)
    {
        //Arrange
        var solution = new IntersectionOfTwoArrays();

        //Act
        var response = solution.SolutionA(nums1, nums2);

        //Assert
        Assert.Equal(response, expectedResponse);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [InlineData(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
    public void SolutionB_ValidInput_MustReturnCorrectAnswer(int[] nums1, int[] nums2, int[] expectedResponse)
    {
        //Arrange
        var solution = new IntersectionOfTwoArrays();

        //Act
        var response = solution.SolutionB(nums1, nums2);

        //Assert
        Assert.Equal(response, expectedResponse);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [InlineData(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 9, 4 })]
    public void SolutionC_ValidInput_MustReturnCorrectAnswer(int[] nums1, int[] nums2, int[] expectedResponse)
    {
        //Arrange
        var solution = new IntersectionOfTwoArrays();

        //Act
        var response = solution.SolutionC(nums1, nums2);

        //Assert
        Assert.Equal(response, expectedResponse);
    }
}