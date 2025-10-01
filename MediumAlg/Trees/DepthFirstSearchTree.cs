namespace MediumAlg.Trees
{
    public static class DepthFirstSearchTree //Busca em profundidade (Depth first search DFS)
    {
        public static int SumNumbers(TreeNode? root)
        {
            string total = string.Empty;
            return Dfs(root!, total);
        }

        private static int Dfs(TreeNode? node, string total)
        {
            if (node == null)
                return 0;

            total += node.val.ToString();

            if (node.left == null && node.right == null)
                return int.Parse(total);

            return Dfs(node.left!, total) + Dfs(node.right!, total);
        }

        public static string PreOrder(TreeNode? node)
        {
            if (node == null) return "";

            string resultado = node.val + " ";
            resultado += PreOrder(node.left);
            resultado += PreOrder(node.right);

            return resultado;
        }

        public static string InOrder(TreeNode? node)
        {
            if (node == null) return "";

            string resultado = InOrder(node.left);
            resultado += node.val + " ";
            resultado += InOrder(node.right);

            return resultado;
        }

        public static string PostOrder(TreeNode? node)
        {
            if (node == null) return "";

            string resultado = PostOrder(node.left);
            resultado += PostOrder(node.right);
            resultado +=node.val + " ";

            return resultado;
        }
    }
}
