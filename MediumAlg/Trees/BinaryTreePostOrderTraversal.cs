namespace MediumAlg.Trees;

public static class BinaryTreePostOrderTraversal
{
    public static IList<int> PostOrderTraversal(TreeNode root)
    {
        List<int> ans = new List<int>();
        if (root == null)
            return ans;

        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        s1.Push(root);

        while (s1.Count > 0)
        {
            TreeNode x = s1.Pop();
            s2.Push(x);
            if (x.left != null)
                s1.Push(x.left);
            if (x.right != null)
                s1.Push(x.right);
        }

        while (s2.Count > 0)
        {
            TreeNode y = s2.Pop();
            ans.Add(y.val);
        }

        return ans;
    }
}
