namespace AlgoPlay.LeetCode.Trees;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;

    public static TreeNode? FromArray(int?[] array)
    {
        if (array.Length == 0 || array[0] is null) return null;

        var root = new TreeNode(array[0]!.Value);
        var q = new Queue<TreeNode>(array.Length / 2 + 1); // the maximum number of nodes at the last level (leave nodes) 
        q.Enqueue(root);

        var i = 1;
        while (i < array.Length && q.TryDequeue(out var node))
        {
            if (array[i] is not null)
            {
                node.left = new TreeNode(array[i]!.Value);
                q.Enqueue(node.left);
            }

            i += 1;

            if (i < array.Length && array[i] is not null)
            {
                node.right = new TreeNode(array[i]!.Value);
                q.Enqueue(node.right);
            }

            i += 1;
        }

        return root;
    }
}