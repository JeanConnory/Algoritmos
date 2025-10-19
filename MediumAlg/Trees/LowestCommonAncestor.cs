namespace MediumAlg.Trees;

public static class LowestCommonAncestor
{
    public static TreeNode? LowestCommonAncestorMethod(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
            return null;

        if (root == p || root == q)
            return root;

        TreeNode? left = LowestCommonAncestorMethod(root.left!, p, q);
        TreeNode? right = LowestCommonAncestorMethod(root.right!, p, q);

        if (left != null && right != null)
            return root;

        if (left != null)
            return left;

        return right;
    }
}
