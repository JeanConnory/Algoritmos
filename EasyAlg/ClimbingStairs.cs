namespace EasyAlg;

public static class ClimbingStairs
{
    public static int ClimbStairsMethod(int n) //Galego
    {
        List<int> list = new List<int>();
        list.Add(1); // Degrau 0
        list.Add(1); // Degrau 1

        for (int i = 2; i < n + 1; i++)
        {
            list.Add(list[i - 1] + list[i - 2]);
        }

        return list[n];
    }

    public static int ClimbStairsMethod2(int n) //Udemy
    {
        if (n == 1)
            return 1;
        
        int[] dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n];
    }
}
