namespace MediumAlg.Trees
{
    //Busca em largura(Breadth first search BFS)
    public class BreadthFirstSearchTree 
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var resultado = new List<IList<int>>();
            if (root == null) return resultado;

            var fila = new Queue<TreeNode>();
            fila.Enqueue(root);

            while (fila.Count > 0)
            {
                int tamanhoNivel = fila.Count;
                var nivelAtual = new List<int>();

                for (int i = 0; i < tamanhoNivel; i++)
                {
                    var no = fila.Dequeue();
                    nivelAtual.Add(no.val);

                    if (no.left != null) fila.Enqueue(no.left);
                    if (no.right != null) fila.Enqueue(no.right);
                }

                resultado.Add(nivelAtual);
            }

            return resultado;
        }
    }
}
