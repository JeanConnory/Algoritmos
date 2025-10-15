using EasyAlg;
using MediumAlg;
using MediumAlg.Trees;
using System.Xml.Linq;

#region Youtube - Jonathan Moura

#region AddTwoNumbers

ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // representa 342
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // representa 465

ListNode resultTwoNumbers = AddTwoNumbers.AddTwoNumbersMethod(l1, l2);

//while (resultTwoNumbers != null)
//{
//    Console.Write(resultTwoNumbers.val);
//    if (resultTwoNumbers.next != null) Console.Write(" -> ");
//    resultTwoNumbers = resultTwoNumbers.next!;
//}
//Console.ReadKey();

#endregion

#endregion

#region Youtube - Galego

#region TwoSumII

int[] numbersTwoSumII = [2, 7, 11, 15];
int targetTwoSumII = 9;

int[] resultTwoSumII = TwoSumII.TwoSum(numbersTwoSumII, targetTwoSumII);

//Console.WriteLine($"Índices encontrados: {string.Join(", ", resultTwoSumII)}");
//Console.ReadKey();

#endregion

#region InverterArvoreBinaria

TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

var tree = InvertBinaryTree.InvertTree(root);

//InvertBinaryTree.PrintTree(tree);

//Console.ReadKey();

#endregion

#region Busca em Profundidade - DFS

TreeNode root2 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

var tree2 = DepthFirstSearchTree.SumNumbers(root2);

//Console.WriteLine("Pré-Ordem: " + DepthFirstSearchTree.PreOrder(root2));
//Console.WriteLine("Em-Ordem: " + DepthFirstSearchTree.InOrder(root2));
//Console.WriteLine("Pós-Ordem: " + DepthFirstSearchTree.PostOrder(root2));
//Console.WriteLine($"Soma dos nós: {tree2.ToString()}");

//Console.ReadKey();

#endregion

#region Busca em Largura - BFS

TreeNode root3 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

var tree3 = BreadthFirstSearchTree.LevelOrder(root3);
//var tree3 = BreadthFirstSearchTree.BreadthFirtsListMethod(root3);

//foreach (var nivel in tree3)
//{
//    Console.WriteLine(string.Join(", ", nivel));
//}

//Console.ReadKey();

#endregion

#region Group Anagrams

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];
var resultAnagrams = GroupAnagrams.GroupAnagramsMethod(strs);

//foreach (var grupo in resultAnagrams)
//{
//    Console.Write("[");
//    foreach (var palavra in grupo)
//    {
//        Console.Write($"\"{palavra}\", ");
//    }
//    Console.WriteLine("]");
//}
//Console.ReadKey();

#endregion

#region Longest Consecutive Sequence

int[] numsConsecutives = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

int resultConsecutives = LongestConsecutiveSequence.LongestConsecutiveMethod(numsConsecutives);
//Console.WriteLine(resultConsecutives);
//Console.ReadKey();

#endregion

#endregion

#region Udemy

#region Container With Most Water

int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

int maxArea = ContainerWithMostWater.MaxArea(height);

//Console.WriteLine(maxArea);

//Console.ReadKey();

#endregion

#region Boats To Save People

int[] people = [3, 2, 2, 1];
int limit = 3;

int numBoats = BoatsToSavePeople.NumRescueBoats(people, limit);

//Console.WriteLine(numBoats);
//Console.ReadKey();

#endregion

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

//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region Count Primes

int verifyPrimes = 36;
int resultPrimes = CountPrimes.CountPrimesMethod(verifyPrimes);

//Console.WriteLine(resultPrimes);
//Console.ReadKey();

#endregion

#region 4sum2 #454

int[] numsSum1 = [1, 2];
int[] numsSum2 = [-2, -1];
int[] numsSum3 = [-1, 2];
int[] numsSum4 = [0, 2];

int resultSums = FourSumCount.FourSumCountMethod(numsSum1, numsSum2, numsSum3, numsSum4);
//Console.WriteLine(resultSums);

#endregion

#endregion

Console.ReadKey();