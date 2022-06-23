namespace DataStructure.Test.Tree.BinarySearchTree;
public class BinarySearchTreeTests
{
    [Fact]
    public void Add_ValidValue_MustAdd()
    {
        //Arrange
        DataStructure.Tree.BinarySearchTree.BinarySearchTree tree = new DataStructure.Tree.BinarySearchTree.BinarySearchTree();

        //Act
        tree.Add(10).Add(5).Add(1).Add(15).Add(22).Add(7).Add(20);

        //Assert
        Assert.Equal(10, tree.Root.Value);
        Assert.Equal(5, tree.Root.LeftNode.Value);
        Assert.Equal(1, tree.Root.LeftNode.LeftNode.Value);
        Assert.Equal(15, tree.Root.RightNode.Value);
        Assert.Equal(22, tree.Root.RightNode.RightNode.Value);
        Assert.Equal(7, tree.Root.LeftNode.RightNode.Value);
        Assert.Equal(20, tree.Root.RightNode.RightNode.LeftNode.Value);
    }

    [Fact]
    public void Remove_ValidValue_MustRemove()
    {
        //Arrange
        DataStructure.Tree.BinarySearchTree.BinarySearchTree tree = new DataStructure.Tree.BinarySearchTree.BinarySearchTree();
        tree.Add(10).Add(5).Add(1).Add(15).Add(22).Add(7).Add(20);

        //Act
        tree.Remove(5);

        //Assert
        Assert.Equal(10, tree.Root.Value);
        Assert.Equal(7, tree.Root.LeftNode.Value);
        Assert.Equal(15, tree.Root.RightNode.Value);
        Assert.Equal(22, tree.Root.RightNode.RightNode.Value);
        Assert.Equal(1, tree.Root.LeftNode.LeftNode.Value);
        Assert.Equal(20, tree.Root.RightNode.RightNode.LeftNode.Value);
    }

    [Fact]
    public void Remove_InvalidValue_DontRemove()
    {
        //Arrange
        DataStructure.Tree.BinarySearchTree.BinarySearchTree tree = new DataStructure.Tree.BinarySearchTree.BinarySearchTree();
        tree.Add(10).Add(5).Add(1).Add(15).Add(22).Add(7).Add(20);

        //Act
        tree.Remove(55);

        //Assert
        Assert.Equal(10, tree.Root.Value);
        Assert.Equal(5, tree.Root.LeftNode.Value);
        Assert.Equal(1, tree.Root.LeftNode.LeftNode.Value);
        Assert.Equal(15, tree.Root.RightNode.Value);
        Assert.Equal(22, tree.Root.RightNode.RightNode.Value);
        Assert.Equal(7, tree.Root.LeftNode.RightNode.Value);
        Assert.Equal(20, tree.Root.RightNode.RightNode.LeftNode.Value);
    }
}