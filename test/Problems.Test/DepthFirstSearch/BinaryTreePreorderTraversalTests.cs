using Problems.DepthFirstSearch;
using Xunit;

namespace Problems.Test.DepthFirstSearch
{
    public class BinaryTreePreorderTraversalTests
    {
        [Fact]
        public void Solution_ValidInput_MustReturnTrue()
        {
            //Arrange
            var solution = new BinaryTreePreorderTraversal();
            var tree = new BinaryTreePreorderTraversal.TreeNode(1, null,
                new BinaryTreePreorderTraversal.TreeNode(2, new BinaryTreePreorderTraversal.TreeNode(3)));

            //Act
            var response = solution.Solution(tree);

            //Assert
            Assert.Equal(1, response[0]);
            Assert.Equal(2, response[1]);
            Assert.Equal(3, response[2]);
        }
    }
}
