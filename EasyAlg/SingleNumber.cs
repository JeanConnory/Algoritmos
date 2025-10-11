namespace EasyAlg;

public static class SingleNumber
{
    public static int SingleNumberMethod(int[] nums)
    {
        Dictionary<int, int> m = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if(m.ContainsKey(num))
                m[num]++;
            else
                m[num] = 1;
        }

        foreach (int num in nums)
        {
            if (m[num] == 1)
                return num;
        }

        return -1;
    }

    public static int SingleNumberMethod2(int[] nums)
    {
        int ans = 0;
        foreach (int num in nums)
        {
            ans ^= num; //Usando XOR (bits)
        }
        return ans;
    }
}
