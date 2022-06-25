using static Problems.DepthFirstSearch.TreeNode;

namespace Problems.Test.DepthFirstSearch;

public class PathSumTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnTrue()
    {
        //Arrange
        var solution = new PathSum();
        var tree = new TreeNode(10, new TreeNode(3), new TreeNode(5, new TreeNode(4)));

        //Act
        var response = solution.Solution(tree, 19);

        //Assert
        Assert.True(response);
    }

    [Fact]
    public void Solution_ValidInput_MustReturnFalse()
    {
        //Arrange
        var solution = new PathSum();
        var tree = new TreeNode(10, new TreeNode(3), new TreeNode(5, new TreeNode(4)));

        //Act
        var response = solution.Solution(tree, 13);

        //Assert
        Assert.True(response);
    }
}