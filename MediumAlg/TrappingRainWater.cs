namespace MediumAlg;

public static class TrappingRainWater
{
    public static int Trap(int[] height)
    {
        int n = height.Length;
        if (n == 0)
            return 0;

        int[] left = new int[n];
        int[] right = new int[n];
        int ans = 0;

        left[0] = height[0];
        for (int i = 1; i < n; i++)
        {
            left[i] = Math.Max(height[i], left[i - 1]);
        }

        right[n - 1] = height[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            right[i] = Math.Max(height[i], right[i + 1]);
        }

        for (int i = 0; i < n; i++)
        {
            ans += Math.Min(right[i], left[i]) - height[i];
        }

        return ans;
    }
}
