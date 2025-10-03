namespace EasyAlg.Sorts
{
    public static class BubbleSort
    {
        public static int[] AlgoritmoBubbleSort(int[] v)
        {
            for (int i = v.Length - 1; i > 0; i--)
            {
                var changes = 0;
                for (int j = 0; j < i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        (v[j], v[j + 1]) = (v[j + 1], v[j]);
                        changes++;
                    }
                }
                if (changes == 0) break;
            }

            return v;
        }
    }
}
