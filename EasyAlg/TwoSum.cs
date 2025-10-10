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
                    return new int[] { mapa[complemento], i }; //Retorna o value da chave do complemento ex: [2,0] return 0 e o i

                mapa[nums[i]] = i; //Adiciona o numero do array como chave e sua posição como valor
            }

            return Array.Empty<int>(); // caso não encontre
        }
    }
}
