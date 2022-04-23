namespace DataStructure.Tree.BinarySearchTree
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; private set; }

        public BinarySearchTree Add(int value)
        {
            if (Root == null)
                Root = new BinarySearchTreeNode(value);
            else
                AddLeaf(Root, value);

            return this;
        }

        private BinarySearchTree AddLeaf(BinarySearchTreeNode root, int value)
        {
            if (value > root.Value)
            {
                if (root.RightNode is null)
                    root.RightNode = new BinarySearchTreeNode(value);
                else
                    AddLeaf(root.RightNode, value);
            }
            else
            {
                if (root.LeftNode is null)
                    root.LeftNode = new BinarySearchTreeNode(value);
                else
                    AddLeaf(root.LeftNode, value);
            }
            return this;
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private BinarySearchTreeNode Remove(BinarySearchTreeNode parent, int value)
        {
            if (parent == null) return parent;

            if (value < parent.Value)
                parent.LeftNode = Remove(parent.LeftNode, value);
            else if (value > parent.Value)
                parent.RightNode = Remove(parent.RightNode, value);
            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                parent.Value = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Value);
            }

            return parent;
        }

        private int MinValue(BinarySearchTreeNode node)
        {
            if (node.LeftNode == null)
                return node.Value;

            return MinValue(node.LeftNode);
        }

        public bool HasValue(int value)
        {
            return Search(value, Root) != null;
        }

        private BinarySearchTreeNode Search(int value, BinarySearchTreeNode node)
        {
            if (node == null)
                return null;

            if (node.Value == value)
                return node;

            if (value < node.Value)
                return Search(value, node.LeftNode);
            else
                return Search(value, node.RightNode);
        }
    }
}
