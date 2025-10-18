
namespace MediumAlg;

public static class PalindromePartitioning
{
    public static IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();
        PartitionHelper(s, new List<string>(), result);
        return result;
    }

    private static void PartitionHelper(string s, List<string> currArr, IList<IList<string>> result)
    {
        if (s.Length == 0)
        {
            result.Add(new List<string>(currArr));
            return;
        }

        for (int i = 1; i <= s.Length; i++)
        {
            string currString = s.Substring(0, i);
            if (IsPalindrome(currString)) 
            {
                currArr.Add(currString);
                PartitionHelper(s.Substring(i), currArr, result);
                currArr.RemoveAt(currArr.Count - 1);
            }
        }
    }

    private static bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
                return false;

            l++;
            r--;
        }
        return true;
    }
}
