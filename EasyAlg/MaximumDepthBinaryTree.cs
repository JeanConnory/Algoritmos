namespace EasyAlg;

public static class MaximumDepthBinaryTree
{
    public static int MaxDepth(TreeNodeEasy root)
    {
        if(root == null)
            return 0;

        return Max(MaxDepth(root.left!), MaxDepth(root.right!)) + 1;
    }

    public static int Max(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

}
