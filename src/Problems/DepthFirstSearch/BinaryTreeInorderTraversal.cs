namespace Problems.DepthFirstSearch;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>

/// <example>
/// Input: root = [1,null,2,3]
/// Output: [1,3,2]
/// </example>

public class BinaryTreeInOrderTraversal
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

        Dfs(root.left, list);
        list.Add(root.val);
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