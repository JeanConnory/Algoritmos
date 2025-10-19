
namespace MediumAlg.Trees;

public class KthElementInBst
{
    private int? res;
    private int? k;

    public int KthSmallest(TreeNode root, int k)
    {
        this.k = k;
        FindKthSmallest(root);
        return res!.Value;
    }

    private void FindKthSmallest(TreeNode root)
    {
        if (root == null)
            return;

        FindKthSmallest(root.left!);
        k--;
        if(k == 0)
            res = root.val;

        FindKthSmallest(root.right!);
    }
}
