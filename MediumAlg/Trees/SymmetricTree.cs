namespace MediumAlg.Trees;

public static class SymmetricTree
{
    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        return IsMirror(root.left, root.right);
    }

    private static bool IsMirror(TreeNode? t1, TreeNode? t2)
    {
        if (t1 == null && t2 == null)
            return true;
        if (t1 == null || t2 == null)
            return false;

        return (t1.val == t2.val) && IsMirror(t1.right, t2.left) && IsMirror(t1.left, t2.right);
    }
}
