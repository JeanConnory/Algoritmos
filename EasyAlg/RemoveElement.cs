namespace EasyAlg;

public static class RemoveElement
{
    public static int RemoveElementMethod(int[] nums, int val)
    {
        int len = nums.Length;
        int i = 0;

        for (var j = 0; j < len; j++)
        {
            if (nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
            }
        }

        return i;
    }
}
