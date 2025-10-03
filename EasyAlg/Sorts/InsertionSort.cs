namespace EasyAlg.Sorts
{
    public static class InsertionSort
    {
        public static int[] InsertionSortMethod(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int atual = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > atual)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = atual;
            }

            return array;
        }

    }
}
