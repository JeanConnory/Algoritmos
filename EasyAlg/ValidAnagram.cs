namespace EasyAlg;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> hashmap = new();

        foreach (char c in s)
            hashmap[c] = hashmap.ContainsKey(c) ? hashmap[c] + 1 : 1;

        foreach (char c in t)
            hashmap[c] = hashmap.ContainsKey(c) ? hashmap[c] - 1 : -1;

        bool isAnagram = hashmap.Values.All(v => v == 0);

        return isAnagram;
    }    
}
