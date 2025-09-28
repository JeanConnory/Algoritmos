namespace EasyAlg
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int m = (left + right) / 2;

                if (nums[m] > target)
                    right = m - 1;
                else if (nums[m] < target)
                    left = m + 1;
                else
                    return m;
            }
            return -1;
        }
    }
}
