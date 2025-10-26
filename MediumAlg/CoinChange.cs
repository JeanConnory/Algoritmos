namespace MediumAlg;

public static class CoinChange
{
    public static int CoinChangeMethod(int[] coins, int amount)
    {
        if (amount <= 0)
            return 0;

        int[] dp = new int[amount + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (coin <= i && dp[i - coin] != int.MaxValue)
                    dp[i] = Math.Min(dp[i - coin] + 1, dp[i]);
            }
        }
        return dp[amount] != int.MaxValue ? dp[amount] : -1;
    }
}
