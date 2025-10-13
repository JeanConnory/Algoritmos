namespace EasyAlg;

public static class MajorityElement
{
    public static int MajorityElementMethod(int[] nums)
    {
        int count = 1;
        int majority = nums[0];
        int n = nums.Length;

        for (int i = 1; i < n; i++)
        {
            if(majority == nums[i])
                count++;
            else
            {
                count--;
                if(count == 0)
                {
                    majority = nums[i];
                    count = 1;
                }
            }
        }
        return majority;
    }
}
