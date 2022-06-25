namespace Problems.Test.DepthFirstSearch;

public class BinaryTreePostOrderTraversalTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new BinaryTreePostOrderTraversal();
        var tree = new BinaryTreePostOrderTraversal.TreeNode(1, null,
            new BinaryTreePostOrderTraversal.TreeNode(2, new BinaryTreePostOrderTraversal.TreeNode(3)));

        //Act
        var response = solution.Solution(tree);

        //Assert
        Assert.Equal(3, response[0]);
        Assert.Equal(2, response[1]);
        Assert.Equal(1, response[2]);
    }
}