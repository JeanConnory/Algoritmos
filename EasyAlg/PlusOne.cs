namespace EasyAlg;

public static class PlusOne
{
    public static int[] PlusOneMethod(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        if (digits[0] == 0)
            digits = [1, .. digits]; //Add 1 no inicio do array

        return digits;
    }
}
