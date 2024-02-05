using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyAlg
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] mergedArr = new int[m + n];
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != 0)
                {
                    mergedArr[i] = nums1[i];
                }
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums2[j] != 0)
                {
                    mergedArr[j+m] = nums2[j];
                }
            }

            for (int k = 0; k < mergedArr.Length; k++)
            {
                for (int x = 0; x < mergedArr.Length - 1; x++)
                {
                    if (mergedArr[x] > mergedArr[x + 1])
                    {
                        int aux = mergedArr[x];
                        mergedArr[x] = mergedArr[x + 1];
                        mergedArr[x + 1] = aux;
                    }
                }
            }

            for (int l = 0; l < mergedArr.Length; l++)
            {
                nums1[l] = mergedArr[l];
            }

            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }
    }
}