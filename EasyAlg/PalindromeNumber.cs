namespace EasyAlg;

public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        int numeroReverso = 0;
        int temp = x;

        while (temp > 0)
        {
            numeroReverso = numeroReverso * 10 + temp % 10;
            temp = temp / 10;
        }

        return numeroReverso == x;
    }
}
