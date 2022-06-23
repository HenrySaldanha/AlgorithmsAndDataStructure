namespace DataStructure.Tree.BinarySearchTree;
public class BinarySearchTreeNode
{
    public BinarySearchTreeNode(int value)
    {
        Value = value;
        LeftNode = null;
        RightNode = null;
    }

    public int Value { get; set; }
    public BinarySearchTreeNode LeftNode { get; set; }
    public BinarySearchTreeNode RightNode { get; set; }
}
