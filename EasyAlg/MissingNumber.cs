namespace EasyAlg;

public static class MissingNumber
{
    public static int MissingNumberMethod(int[] nums)
    {
        int currentSum = nums.Sum();
        int n = nums.Length;
        int intendedSum = n * (n + 1) / 2; //Formula de Gauss
        return intendedSum - currentSum;
    }
}
