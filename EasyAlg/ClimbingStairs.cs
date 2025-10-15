namespace EasyAlg;

public static class ClimbingStairs
{
    public static int ClimbStairsMethod(int n)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(1);

        for (int i = 2; i < n + 1; i++)
        {
            list.Add(list[i - 1] + list[i - 2]);
        }

        return list[n];
    }
}
