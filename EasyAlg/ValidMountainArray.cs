﻿namespace EasyAlg
{
    public static class ValidMountainArray
    {
        public static bool ValidMountainArrayMethod(int[] arr)
        {
            int i = 1;

            while (i < arr.Length && arr[i] > arr[i - 1])
            {
                i++;
            }

            if (i == 1 || i == arr.Length)
            {
                return false;
            }

            while (i < arr.Length && arr[i] < arr[i - 1])
            {
                i++;
            }
            return i == arr.Length;
        }
    }
}
