using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LengthOfLongestSubstring
{
    public class LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstringMethod(string s)
        {
            Dictionary<char, int> m = new Dictionary<char, int>();
            int ans = 0;
            int left = 0;
            int right = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                if (m.ContainsKey(s[i]))
                {
                    left = Math.Max(left, m[s[i]] + 1);
                }
                right += 1;
                m[s[i]] = i;
                ans = Math.Max(right - left, ans);
            }
            return ans;
        }
    }
}