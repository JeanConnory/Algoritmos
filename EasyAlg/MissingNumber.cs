namespace EasyAlg;

public static class MissingNumber
{
    public static int MissingNumberMethod(int[] nums) //Udemy
    {
        int currentSum = nums.Sum();
        int n = nums.Length;
        int intendedSum = n * (n + 1) / 2; //Formula de Gauss
        return intendedSum - currentSum;
    }

    public static int MissingNumberMethod2(int[] nums) //Galego Bitwise
    {
        int x = 0;
        foreach (int num in nums)
        {
            x ^= num;
        }

        for (int i = 0; i < nums.Length + 1; i++)
        {
            x ^= i;
        }

        return x;
    }
}
