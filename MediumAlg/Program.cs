using MediumAlg;
using MediumAlg.Trees;

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
