namespace EasyAlg;

public static class BestTimeBuySellStock
{
    public static int MaxProfit(int[] prices)
    {
        int buyPrice = int.MaxValue;
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < buyPrice)
                buyPrice = prices[i];
            else
                profit = Math.Max(profit, prices[i] - buyPrice);
        }
        return profit;
    }
}
