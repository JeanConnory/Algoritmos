namespace EasyAlg.Sorts
{
    public static class SelectionSort
    {
        public static int[] Selection(int[] arr)
        {
            int index = 0;
            int minPos = 0;
            int length = arr.Length;

            while (index < length)
            {
                minPos = index;

                for (int i = index + 1; i < length; i++)
                {
                    if (arr[i] < arr[minPos])
                    {
                        minPos = i;
                    }
                }
                
                int temp = arr[index];
                arr[index] = arr[minPos];
                arr[minPos] = temp;
                index++;
            }

            return arr;
        }
    }
}
