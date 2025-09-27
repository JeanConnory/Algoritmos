using MediumAlg;

#region Legth of Longest Substring

string s = "abcabcbb";
LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
int longestSubstring = lengthOfLongestSubstring.LengthOfLongestSubstringMethod(s);

#endregion

#region Find First And Last Position Of Element In Sorted Array

int[] nums = [5, 7, 7, 8, 8, 10];
int target = 8;

FindFirstAndLastPositionOfElementInSortedArray testMethod = new FindFirstAndLastPositionOfElementInSortedArray();
int[] result = testMethod.SearchRange(nums, target);

//result.ToList().ForEach(n => Console.WriteLine(n));
//Console.WriteLine(string.Join(", ", result));

#endregion

Console.WriteLine(result);
Console.ReadKey();