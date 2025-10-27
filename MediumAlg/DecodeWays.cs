namespace MediumAlg;

public static class DecodeWays
{
    public static int NumDecodings(string s)
    {
        if(string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;

        int n = s.Length;
        int prev = 1;
        int curr = 1;

        for (int i = 1; i < n; i++)
        {
            int temp = 0;

            if (s[i] != '0')
            {
                temp += curr;
            }

            int twoDigit = int.Parse(s.Substring(i - 1, 2));
            if(twoDigit >= 10 && twoDigit <= 26)
            {
                temp += prev;
            }
            prev = curr;
            curr = temp;

            if (curr == 0)
                return 0;
        }

        return curr;
    }
}
