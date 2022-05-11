using Problems.DepthFirstSearch;
using Xunit;

namespace Problems.Test.DepthFirstSearch
{
    public class BinaryTreeInorderTraversalTests
    {
        [Fact]
        public void Solution_ValidInput_MustReturnTrue()
        {
            //Arrange
            var solution = new BinaryTreeInorderTraversal();
            var tree = new BinaryTreeInorderTraversal.TreeNode(1, null,
                new BinaryTreeInorderTraversal.TreeNode(2, new BinaryTreeInorderTraversal.TreeNode(3)));

            //Act
            var response = solution.Solution(tree);

            //Assert
            Assert.Equal(1, response[0]);
            Assert.Equal(3, response[1]);
            Assert.Equal(2, response[2]);
        }
    }
}
