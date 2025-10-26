namespace MediumAlg;

public static class LongestPalindromeSubstring
{
    public static string LongestPalindrome(string st)
    {
        string ans = string.Empty;
        int n = st.Length;
        bool[,] isPalindrome = new bool[n,n];

        for (int i = 0; i < n; i++)
        {
            isPalindrome[i, i] = true;
        }

        for (int e = 0; e < n; e++)
        {
            for (int s = 0; s <= e; s++)
            {
                int middleStringLength = e - s - 1;
                bool sameChar = st[s] == st[e];

                if(sameChar && (middleStringLength <= 1 || isPalindrome[s + 1, e - 1]))
                {
                    isPalindrome[s, e] = true;
                    if(e - s >= ans.Length)
                        ans = st.Substring(s, e - s + 1);
                }
            }
        }
        return ans;
    }
}
