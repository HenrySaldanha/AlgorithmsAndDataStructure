using Search.BinarySearchTree;

namespace Search.Test.BinarySearchTree;

public class BinarySearchTreeTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(110)]
    public void HasValue_InvalidValue_ReturnFalse(int value)
    {
        //Arrange
        DataStructure.Tree.BinarySearchTree.BinarySearchTree tree = new DataStructure.Tree.BinarySearchTree.BinarySearchTree();
        tree.Add(10).Add(5).Add(1).Add(15).Add(22).Add(7).Add(20);

        //Act
        var result = tree.HasValue(value);

        //Assert
        Assert.False(result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(22)]
    public void HasValue_ValidValue_ReturnTrue(int value)
    {
        //Arrange
        DataStructure.Tree.BinarySearchTree.BinarySearchTree tree = new DataStructure.Tree.BinarySearchTree.BinarySearchTree();
        tree.Add(10).Add(5).Add(1).Add(15).Add(22).Add(7).Add(20);

        //Act
        var result = tree.HasValue(value);

        //Assert
        Assert.True(result);
    }
}