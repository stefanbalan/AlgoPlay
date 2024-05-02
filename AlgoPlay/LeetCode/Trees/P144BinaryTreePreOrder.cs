namespace AlgoPlay.LeetCode.Trees;

public class P144BinaryTreePreOrder
{
    //144. Binary Tree Preorder Traversal

    //Given the root of a binary tree, return the preorder traversal of its nodes' values.
    // 
    // Example 1:
    // 
    // 
    // Input: root = [1,null,2,3]
    // Output: [1,2,3]
    // Example 2:
    // 
    // Input: root = []
    // Output: []
    // Example 3:
    // 
    // Input: root = [1]
    // Output: [1]
    //  
    // 
    // Constraints:
    // 
    // The number of nodes in the tree is in the range [0, 100].
    // -100 <= Node.val <= 100
    //  
    // 
    // Follow up: Recursive solution is trivial, could you do it iteratively?

    public IList<int> PreorderTraversal(TreeNode? root)
    {
        //var maxStackSize = 0;
        var result = new List<int>(100);
        if (root == null) return result;

        var current = root;
        var stack = new Stack<TreeNode>(100);
        stack.Push(root);
        do
        {
            while (current is not null)
            {
                result.Add(current.val);
                stack.Push(current);
                current = current.left;
            }

            //maxStackSize = Math.Max(maxStackSize, stack.Count);
            current = stack.Pop();

            current = current.right;
        } while (stack.Count > 0);

        return result;
    }

    public IList<int> PreorderTraversal1(TreeNode? root) // all stack!
    {
        //var maxStackSize = 0;
        var result = new List<int>(100);
        if (root == null) return result;

        TreeNode current;
        var stack = new Stack<TreeNode>(100);
        stack.Push(root);
        while (stack.Count > 0)
        {
            current = stack.Pop();
            result.Add(current.val);
            if(current.right != null) stack.Push(current.right);
            if(current.left != null) stack.Push(current.left);
            //maxStackSize = Math.Max(maxStackSize, stack.Count);
        }

        return result;
    }
    
    public IList<int> PreorderTraversal2(TreeNode? root) // I thought this would be faster but it's not
    {
        //var maxStackSize = 0;

        var result = new List<int>(100);
        if (root == null) return result;

        var current = root;
        var stack = new Stack<TreeNode>(100);

        while (current is not null)
        {
            result.Add(current.val);
            if (current.left is not null)
            {
                if (current.right != null) stack.Push(current.right);
                current = current.left;
            }
            else if (current.right != null) current = current.right;

            else if (stack.Count > 0)
            {
                //maxStackSize = Math.Max(maxStackSize, stack.Count);

                current = stack.Pop();
            }
            else
                current = null;
        }

        return result;
    }
}