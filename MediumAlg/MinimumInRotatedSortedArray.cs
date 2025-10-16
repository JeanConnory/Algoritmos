namespace MediumAlg;

public static class MinimumInRotatedSortedArray
{
    public static int FindMin(int[] nums)
    {
        int result = nums[0];
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] <= nums[right])
                return nums[left];

            int mid = (left + right) / 2;

            if (nums[mid] >= nums[left])
                left = mid + 1;
            else
                right = mid;
        }

        return 0;
    }
}
