namespace Problems.DepthFirstSearch;

/// <summary>
/// Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf
/// path such that adding up all the values along the path equals targetSum.
/// A leaf is a node with no children.
/// </summary>

/// <example>
/// Input: strs = ["eat","tea","tan","ate","nat","bat"]
/// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
/// </example>

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
    public class PathSum
    {
        public bool Solution(TreeNode root, int targetSum)
        {
            if (root is null)
                return false;

            if (root.val == targetSum && root.left is null && root.right is null)
                return true;
            else
                return Solution(root.left, targetSum - root.val) || Solution(root.right, targetSum - root.val);
        }
    }
}