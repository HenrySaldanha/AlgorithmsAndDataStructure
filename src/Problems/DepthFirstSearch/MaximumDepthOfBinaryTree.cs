namespace Problems.DepthFirstSearch;

/// <summary>
/// Given the root of a binary tree, return its maximum depth.
/// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
/// </summary>

/// <example>
/// Input: root = [3,9,20,null,null,15,7]
/// Output: 3
/// </example>

/// <example>
/// Input: root = [1,null,2]
/// Output: 2
/// </example>

public class MaximumDepthOfBinaryTree
{
    public int Solution(TreeNode root)
    {
        if (root is null)
            return 0;

        var left = Solution(root.left);
        var right = Solution(root.right);
        return left > right ? left + 1 : right + 1;
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