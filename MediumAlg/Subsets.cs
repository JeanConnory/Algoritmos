
namespace MediumAlg;

public static class Subsets
{
    public static IList<IList<int>> SubsetsMethod(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> cur = new List<int>();

        SolutionHelper(nums, ans, cur, 0);

        return ans;
    }

    private static void SolutionHelper(int[] nums, IList<IList<int>> ans, List<int> cur, int index)
    {
        if (index > nums.Length)
            return;

        ans.Add(new  List<int>(cur));

        for (int i = index; i < nums.Length; i++)
        {
            if(!cur.Contains(nums[i]))
            {
                cur.Add(nums[i]);
                SolutionHelper(nums, ans, cur, i);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
