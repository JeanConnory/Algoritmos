
namespace MediumAlg.Trees;

public static class BinaryTreeMaximumPathSum
{
    private static int ans = int.MinValue;

    public static int MaxPathSum(TreeNode root)
    {
        CalculateMaxPathSum(root);
        return ans;
    }

    private static int CalculateMaxPathSum(TreeNode root)
    {
        if (root == null) return 0;

        int left = CalculateMaxPathSum(root.left!);
        int right = CalculateMaxPathSum(root.right!);

        int mxSide = Math.Max(root.val, root.val + Math.Max(left, right));
        int mxCurrent = Math.Max(mxSide, root.val + left + right);

        ans = Math.Max(ans, mxCurrent);

        return mxSide;
    }
}
