namespace MediumAlg;

public static class HouseRobber
{
    public static int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 1)
            return nums[0];

        int house1 = nums[0];
        int house2 = Math.Max(nums[0], nums[1]);
        int ans = house2;

        for (int i = 2; i < n; i++)
        {
            ans = Math.Max(house2, nums[i] + house1);
            house1 = house2;
            house2 = ans;
        }

        return ans;
    }
}
