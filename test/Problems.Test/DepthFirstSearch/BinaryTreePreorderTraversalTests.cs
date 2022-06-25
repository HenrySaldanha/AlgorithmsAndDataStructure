namespace Problems.Test.DepthFirstSearch;

public class BinaryTreePreOrderTraversalTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new BinaryTreePreOrderTraversal();
        var tree = new BinaryTreePreOrderTraversal.TreeNode(1, null,
            new BinaryTreePreOrderTraversal.TreeNode(2, new BinaryTreePreOrderTraversal.TreeNode(3)));

        //Act
        var response = solution.Solution(tree);

        //Assert
        Assert.Equal(1, response[0]);
        Assert.Equal(2, response[1]);
        Assert.Equal(3, response[2]);
    }
}