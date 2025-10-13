namespace EasyAlg;

public static class ContainsDuplicate
{
    public static bool ContainsDuplicateMethod(int[] nums)
    {
        var m = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; ++i)
        {
            if (m.ContainsKey(nums[i]))
            {
                return true;
            }
            m[nums[i]] = true;
        }
        return false;
    }
}
