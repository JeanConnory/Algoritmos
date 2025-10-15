namespace MediumAlg;

public static class GroupAnagrams
{
    public static IList<IList<string>> GroupAnagramsMethod(string[] strs)
    {
        Dictionary<string, List<string>> dic = new();

        foreach (var item in strs)
        {
            var str = item.ToCharArray();
            Array.Sort(str);

            if (!dic.ContainsKey(new string(str)))
                dic.Add(new string(str), new List<string>());

            dic[new string(str)].Add(item);
        }

        var result = new List<IList<string>>(); //(dic.Values)

        foreach (List<string> list in dic.Values)
        {
            result.Add(list.Cast<string>().ToList().AsReadOnly());
        }

        return result;
    }
}
