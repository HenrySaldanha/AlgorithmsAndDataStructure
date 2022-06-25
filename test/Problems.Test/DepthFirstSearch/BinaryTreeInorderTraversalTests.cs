namespace Problems.Test.DepthFirstSearch;

public class BinaryTreeInOrderTraversalTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new BinaryTreeInOrderTraversal();
        var tree = new BinaryTreeInOrderTraversal.TreeNode(1, null,
            new BinaryTreeInOrderTraversal.TreeNode(2, new BinaryTreeInOrderTraversal.TreeNode(3)));

        //Act
        var response = solution.Solution(tree);

        //Assert
        Assert.Equal(1, response[0]);
        Assert.Equal(3, response[1]);
        Assert.Equal(2, response[2]);
    }
}