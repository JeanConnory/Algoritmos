namespace EasyAlg;

public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        List<char> stack = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char digit = s[i];
            if (brackets.ContainsKey(digit))
            {
                stack.Add(digit);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char lastOpen = stack[stack.Count - 1];
                if (brackets[lastOpen] != digit)
                {
                    return false;
                }
                stack.RemoveAt(stack.Count - 1);
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
