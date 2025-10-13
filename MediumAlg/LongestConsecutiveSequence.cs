namespace MediumAlg;

public static class LongestConsecutiveSequence
{
    public static int LongestConsecutiveMethod(int[] nums)
    {
        if (nums.Length == 0) return 0;

        Array.Sort(nums);

        int best = 1;
        int current = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                continue;

            if (nums[i] == nums[i - 1] + 1)
                current += 1;
            else
                current = 1;

            if (current > best)
                best = current;
        }

        return best;
    }
}
