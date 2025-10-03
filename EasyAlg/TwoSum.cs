namespace EasyAlg
{
    public static class TwoSum
    {
        public static int[] TwoSumMethod(int[] nums, int target)
        {
            var mapa = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complemento = target - nums[i];

                if (mapa.ContainsKey(complemento))
                    return new int[] { mapa[complemento], i };

                mapa[nums[i]] = i;
            }

            return Array.Empty<int>(); // caso não encontre
        }
    }
}
