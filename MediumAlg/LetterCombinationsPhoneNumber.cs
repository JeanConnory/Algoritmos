
namespace MediumAlg;

public static class LetterCombinationsPhoneNumber
{
    public static IList<string> LetterCombinations(string digits)
    {
        if(digits.Length == 0)
            return new List<string>();

        Dictionary<char, string> digitToString = new Dictionary<char, string>()
        {
            {'2', "abc" },
            {'3', "def" },
            {'4', "ghi" },
            {'5', "jkl" },
            {'6', "mno" },
            {'7', "pqrs" },
            {'8', "tuv" },
            {'9', "wxyz" }
        };

        List<string> ans = new List<string>();
        LetterCombinationsHelper(digits, digitToString, "", ans, 0);
        return ans;
    }

    private static void LetterCombinationsHelper(string digits, Dictionary<char, string> digitToString, string cur, List<string> ans, int digitIndex)
    {
        if (cur.Length == digits.Length)
        {
            ans.Add(cur);
            return;
        }

        char currentDigit = digits[digitIndex];
        string currentString = digitToString[currentDigit];

        for (int i = 0; i < currentString.Length; i++) 
        { 
            char character = currentString[i];
            LetterCombinationsHelper(digits, digitToString, cur + character, ans, digitIndex + 1);
        }
    }
}
