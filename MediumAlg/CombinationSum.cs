namespace MediumAlg;

public static class CombinationSum
{
    public static IList<IList<int>> CombinationSumMethod(int[] candidates, int target)
    {
        List<IList<int>> ans = new List<IList<int>>();
        List<int> curr = new List<int>();
        CombinationSumHelper(new List<int>(candidates), ans, curr, target, 0, 0);
        return ans;
    }

    private static IList<IList<int>> CombinationSumHelper(List<int> candidates, List<IList<int>> ans, List<int> curr, int target, int index, int sum)
    {
        if (sum == target)
        {
            ans.Add(new List<int>(curr));
        }
        else if (sum < target)
        {
            int n = candidates.Count;
            for (int i = index; i < n; i++)
            {
                curr.Add(candidates[i]);
                CombinationSumHelper(candidates, ans, curr, target, i, sum + candidates[i]);
                curr.RemoveAt(curr.Count - 1);
            }
        }
        return ans;
    }
}
