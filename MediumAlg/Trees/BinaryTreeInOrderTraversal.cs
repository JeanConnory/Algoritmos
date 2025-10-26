namespace MediumAlg.Trees;

public class BinaryTreeInOrderTraversal
{
    public IList<int> InOrderTraversal(TreeNode root)
    {
        List<int> resultado = new List<int>();
        Percorrer(root, resultado);
        return resultado;
    }

    private void Percorrer(TreeNode node, List<int> resultado)
    {
        if (node == null) return;

        Percorrer(node.left!, resultado);     // 1. Visita esquerda
        resultado.Add(node.val);             // 2. Visita raiz
        Percorrer(node.right!, resultado);    // 3. Visita direita
    }
}
