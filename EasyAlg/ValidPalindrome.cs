namespace EasyAlg;

public static class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        if(string.IsNullOrEmpty(s)) return false;

        int start = 0;
        int end = s.Length - 1;

        while (start <= end)
        {
            char currFirst = s[start];
            char currLast = s[end];

            if (!char.IsLetterOrDigit(currFirst))
                start++;
            else if (!char.IsLetterOrDigit(currLast))
                end--;
            else
            {
                if(char.ToLower(currFirst) != char.ToLower(currLast))
                    return false;

                start++;
                end--;
            }
        }
        return true;
    }
}
