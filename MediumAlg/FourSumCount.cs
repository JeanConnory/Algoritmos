namespace MediumAlg;

public static class FourSumCount
{
    public static int FourSumCountMethod(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums3.Length; j++)
            {
                int target = nums1[i] + nums3[j];
                if(!map.ContainsKey(target))
                    map[target] = 0;
                map[target]++;
            }
        }
        int ans = 0;
        for (int i = 0; i < nums2.Length; i++)
        {
            for (int j = 0; j < nums4.Length; j++)
            {
                int target = -(nums2[i] + nums4[j]);
                if (map.ContainsKey(target))
                    ans += map[target];                
            }
        }
        return ans;
    }
}
