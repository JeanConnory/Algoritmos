namespace MediumAlg.Trees
{
    public static class InvertBinaryTree
    {
        public static TreeNode? InvertTree(TreeNode? root)
        {
            if (root is null)
                return null;

            TreeNode? temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        public static void PrintTree(TreeNode? node)
        {
            if (node == null) return;
            Console.Write(node.val + " ");
            PrintTree(node.left);
            PrintTree(node.right);
        }
    }
}
