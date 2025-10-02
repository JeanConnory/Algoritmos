namespace MediumAlg
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int l = 0; //1,
            int r = height.Length - 1; //8,7,6
            while (l < r)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[l], height[r]) * (r - l)); //1*8=8 //7*7=49 //3*6=18 MA=49 //5*8=40 MA=49
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return maxArea;//8,49
        }
    }
}
