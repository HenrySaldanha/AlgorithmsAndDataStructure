namespace DataStructure.Tree.AVL;
public class AVLNode
{
    public AVLNode(int value)
    {
        Value = value;
        Height = 1;
    }

    public int Value { get; set; }
    public int Height { get; set; }
    public AVLNode LeftNode { get; set; }
    public AVLNode RightNode { get; set; }
}
