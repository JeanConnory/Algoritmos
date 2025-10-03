namespace EasyAlg.Sorts
{
    public static class HeapSort
    {
        public static void HeapSortMethod(int[] array)
        {
            int n = array.Length;

            // Passo 1: construir o max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // Passo 2: extrair elementos do heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move o maior elemento (raiz) para o final
                (array[0], array[i]) = (array[i], array[0]);

                // Heapify na raiz com heap reduzido
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int maior = i;
            int esquerda = 2 * i + 1;
            int direita = 2 * i + 2;

            if (esquerda < n && array[esquerda] > array[maior])
                maior = esquerda;

            if (direita < n && array[direita] > array[maior])
                maior = direita;

            if (maior != i)
            {
                (array[i], array[maior]) = (array[maior], array[i]);
                Heapify(array, n, maior);
            }
        }
    }
}
