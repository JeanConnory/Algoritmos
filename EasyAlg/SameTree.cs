namespace EasyAlg;

public static class SameTree
{
    public static bool IsSameTree(TreeNodeEasy p, TreeNodeEasy q)
    {
        if(p == null &&  q == null) return true;

        if (p != null && q != null)
        {
            return p.val == q.val && IsSameTree(p.left!, q.left!) && IsSameTree (p.right!, q.right!);
        }
        return false;
    }
}
