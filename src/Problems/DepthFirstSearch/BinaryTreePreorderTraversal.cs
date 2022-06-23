namespace Problems.DepthFirstSearch;

/// <summary>
/// Given the root of a binary tree, return the preorder traversal of its nodes' values.
/// </summary>

/// <example>
/// Input: root = [1,null,2,3]
/// Output: [1,2,3]
/// </example>

public class BinaryTreePreOrderTraversal
{
    public IList<int> Solution(TreeNode root)
    {
        var list = new List<int>();
        Dfs(root, list);
        return list;
    }

    public void Dfs(TreeNode root, List<int> list)
    {
        if (root is null)
            return;

        list.Add(root.val);
        Dfs(root.left, list);
        Dfs(root.right, list);
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}