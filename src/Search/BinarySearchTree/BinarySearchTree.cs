using DataStructure.Tree.BinarySearchTree;

namespace Search.BinarySearchTree
{
    public static class BinarySearchTree
    {
        public static bool HasValue(this DataStructure.Tree.BinarySearchTree.BinarySearchTree tree, int value)
        {
            return Search(value, tree.Root) is not null;
        }

        private static BinarySearchTreeNode Search(int value, BinarySearchTreeNode node)
        {
            if (node is null)
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
