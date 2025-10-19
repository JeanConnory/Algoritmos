namespace MediumAlg.Trees;

public static class PathSum
{
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        return HasSum(root, targetSum, 0);
    }

    private static bool HasSum(TreeNode root, int targetSum, int cur)
    {
        cur += root.val;
        if (cur == targetSum && root.left == null && root.right == null) //Verificando se tambem é uma folha(leaf) sem nodos a esquerda e direita
        {
            return true;
        }

        if (root.left! != null)
        {
            if (HasSum(root.left!, targetSum, cur))
            {
                return true;
            }
        }

        if (root.right! != null)
        {
            if (HasSum(root.right!, targetSum, cur))
            {
                return true;
            }
        }

        return false;
    }

    public static void ImprimirPathSum(TreeNode root, int targetSum)
    {
        List<int> caminho = new List<int>();
        BuscarCaminho(root, targetSum, 0, caminho);
    }

    private static bool BuscarCaminho(TreeNode root, int targetSum, int somaAtual, List<int> caminho)
    {
        if (root == null) return false;

        somaAtual += root.val;
        caminho.Add(root.val);

        if (somaAtual == targetSum && root.left == null && root.right == null)
        {
            Console.WriteLine("[" + string.Join(", ", caminho) + "]");
            return true;
        }

        bool encontrou = false;

        if (root.left != null)
            encontrou |= BuscarCaminho(root.left, targetSum, somaAtual, caminho);

        if (root.right != null)
            encontrou |= BuscarCaminho(root.right, targetSum, somaAtual, caminho);

        caminho.RemoveAt(caminho.Count - 1); // backtrack

        return encontrou;
    }

}
