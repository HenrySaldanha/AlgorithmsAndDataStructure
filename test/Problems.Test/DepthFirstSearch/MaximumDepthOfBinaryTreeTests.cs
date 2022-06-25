namespace Problems.Test.DepthFirstSearch;

public class MaximumDepthOfBinaryTreeTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new MaximumDepthOfBinaryTree();
        var tree = new MaximumDepthOfBinaryTree.TreeNode(3, new MaximumDepthOfBinaryTree.TreeNode(9),
            new MaximumDepthOfBinaryTree.TreeNode(20, new MaximumDepthOfBinaryTree.TreeNode(15), new MaximumDepthOfBinaryTree.TreeNode(7)));

        //Act
        var response = solution.Solution(tree);

        //Assert
        Assert.Equal(3, response);
    }
}