using Xunit;

namespace DataStructure.Test.Tree.AVL
{
    public class AVLTests
    {
        [Fact]
        public void Add_ValidValue_MustAdd()
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();

            //Act
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Assert
            Assert.Equal(4, tree.Root.Value);
            Assert.Equal(2, tree.Root.LeftNode.Value);
            Assert.Equal(1, tree.Root.LeftNode.LeftNode.Value);
            Assert.Equal(3, tree.Root.LeftNode.RightNode.Value);
            Assert.Equal(6, tree.Root.RightNode.Value);
            Assert.Equal(5, tree.Root.RightNode.LeftNode.Value);
            Assert.Equal(7, tree.Root.RightNode.RightNode.Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void Search_ValidValue_MustReturnNode(int value)
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Act
            var result = tree.Search(value);


            //Assert
            Assert.Equal(value, result.Value);
        }

        [Fact]
        public void Search_InvalidValue_MustReturnNull()
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Act
            var result = tree.Search(12);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void Remove_InvalidValue_DontRemove()
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Act
            tree.Remove(12);

            //Assert
            Assert.Equal(4, tree.Root.Value);
            Assert.Equal(2, tree.Root.LeftNode.Value);
            Assert.Equal(1, tree.Root.LeftNode.LeftNode.Value);
            Assert.Equal(3, tree.Root.LeftNode.RightNode.Value);
            Assert.Equal(6, tree.Root.RightNode.Value);
            Assert.Equal(5, tree.Root.RightNode.LeftNode.Value);
            Assert.Equal(7, tree.Root.RightNode.RightNode.Value);
        }

        [Fact]
        public void Remove_ValidValue_MustRemove()
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Act
            tree.Remove(1);

            //Assert
            Assert.Equal(4, tree.Root.Value);
            Assert.Equal(2, tree.Root.LeftNode.Value);
            Assert.Equal(3, tree.Root.LeftNode.RightNode.Value);
            Assert.Equal(6, tree.Root.RightNode.Value);
            Assert.Equal(5, tree.Root.RightNode.LeftNode.Value);
            Assert.Equal(7, tree.Root.RightNode.RightNode.Value);
        }

        [Fact]
        public void Remove_ValidValue_MustRemoveAndRotate()
        {
            //Arrange
            DataStructure.Tree.AVL.AVL tree = new DataStructure.Tree.AVL.AVL();
            tree.Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7);

            //Act
            tree.Remove(1).Remove(2).Remove(3);

            //Assert
            Assert.Equal(6, tree.Root.Value);
            Assert.Equal(4, tree.Root.LeftNode.Value);
            Assert.Equal(5, tree.Root.LeftNode.RightNode.Value);
            Assert.Equal(7, tree.Root.RightNode.Value);
        }
    }
}
