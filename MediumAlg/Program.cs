using EasyAlg;
using MediumAlg;
using MediumAlg.Trees;
using System.Drawing;
using System.Xml.Linq;

#region Youtube - Jonathan Moura

#region AddTwoNumbers #2

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

#region Minimum Rotated Sorted Array #153

int[] numsRotated = [3, 4, 5, 1, 2, 0];
int resultMinimunRotated = MinimumInRotatedSortedArray.FindMin(numsRotated);
//Console.WriteLine(resultMinimunRotated);

#endregion

#endregion

#region Youtube - Galego

#region TwoSumII #167

int[] numbersTwoSumII = [2, 7, 11, 15];
int targetTwoSumII = 9;

int[] resultTwoSumII = TwoSumII.TwoSum(numbersTwoSumII, targetTwoSumII);

//Console.WriteLine($"Índices encontrados: {string.Join(", ", resultTwoSumII)}");
//Console.ReadKey();

#endregion

#region InverterArvoreBinaria #226

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

#region Busca em Largura - BFS #102

TreeNode root3 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

var tree3 = BreadthFirstSearchTree.LevelOrder(root3);
//var tree3 = BreadthFirstSearchTree.BreadthFirtsListMethod(root3);

//foreach (var nivel in tree3)
//{
//    Console.WriteLine(string.Join(", ", nivel));
//}

#endregion

#region Group Anagrams #49

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

#endregion

#region Longest Consecutive Sequence #128

int[] numsConsecutives = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];

int resultConsecutives = LongestConsecutiveSequence.LongestConsecutiveMethod(numsConsecutives);
//Console.WriteLine(resultConsecutives);
//Console.ReadKey();

#endregion

#region Copy List with Random Pointer

Node n1 = new Node(1);
Node n2 = new Node(2);
Node n3 = new Node(3);

n1.next = n2;
n2.next = n3;

n1.random = n3;
n2.random = n1;
n3.random = n2;

// Clonando
Node curr = CopyListRandomPointer.CopyRandomList(n1);

//while (curr != null)
//{
//    string randomVal = curr.random != null ? curr.random.val.ToString() : "null";
//    Console.WriteLine($"Valor: {curr.val}, Next: {(curr.next != null ? curr.next.val.ToString() : "null")}, Random: {randomVal}");
//    curr = curr.next!;
//}

#endregion

#region BinaryTree InOrderTraversal #94

TreeNode rootInOrder = new TreeNode(1,
    null,
    new TreeNode(2,
        new TreeNode(3),
        null
    )
);

BinaryTreeInOrderTraversal bTreeInOrder = new BinaryTreeInOrderTraversal();
var resultBTreeInorder = bTreeInOrder.InOrderTraversal(rootInOrder);

//Console.WriteLine("InOrder:");
//Console.WriteLine("[" + string.Join(", ", resultBTreeInorder) + "]");

#endregion

#endregion

#region Udemy

#region Container With Most Water #11

int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

int maxArea = ContainerWithMostWater.MaxArea(height);

//Console.WriteLine(maxArea);

//Console.ReadKey();

#endregion

#region Boats To Save People #881

int[] people = [3, 2, 2, 1];
int limit = 3;

int numBoats = BoatsToSavePeople.NumRescueBoats(people, limit);

//Console.WriteLine(numBoats);
//Console.ReadKey();

#endregion

#region Legth of Longest Substring #3

string s = "abcabcbb";
LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
int longestSubstring = lengthOfLongestSubstring.LengthOfLongestSubstringMethod(s);

#endregion

#region Find First And Last Position Of Element In Sorted Array #34

int[] nums = [5, 7, 7, 8, 8, 10];
int target = 8;

FindFirstAndLastPositionOfElementInSortedArray testMethod = new FindFirstAndLastPositionOfElementInSortedArray();
int[] result = testMethod.SearchRange(nums, target);

//result.ToList().ForEach(n => Console.WriteLine(n));
//Console.WriteLine(string.Join(", ", result));

//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region Count Primes #204

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

#region Remove Nth Element from the end of List #19

int nElement = 2;
ListNode listRemoveNthElement = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
ListNode resultRemoveNthElement = RemoveNthElementFromEnd.RemoveNthFromEnd(listRemoveNthElement, nElement);

//while (resultRemoveNthElement != null)
//{
//    Console.Write(resultRemoveNthElement.val);
//    if (resultRemoveNthElement.next != null) Console.Write(" -> ");
//    resultRemoveNthElement = resultRemoveNthElement.next!;
//}

#endregion

#region Odd Even Linked List #328

ListNode listOddEven = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
ListNode resultListOddEven = OddEvenLinkedList.OddEvenListMethod(listOddEven);

//while (resultListOddEven != null)
//{
//    Console.Write(resultListOddEven.val);
//    if (resultListOddEven.next != null) Console.Write(" -> ");
//    resultListOddEven = resultListOddEven.next!;
//}

#endregion

#region Subsets #78

int[] numsSubsets = [1, 2, 3,];

var resultSubsets = Subsets.SubsetsMethod(numsSubsets);

//foreach (var sublista in resultSubsets)
//{
//    Console.Write("[");
//    foreach (var numero in sublista)
//    {
//        Console.Write(numero + " ");
//    }
//    Console.WriteLine("]");
//}

#endregion

#region Letter Combinations of a Phone Number # 17

string digits = "23";

var resultPhoneNumbers = LetterCombinationsPhoneNumber.LetterCombinations(digits);

//foreach (var sublista in resultPhoneNumbers)
//{
//    Console.Write("[");
//    foreach (var numero in sublista)
//    {
//        Console.Write(numero + " ");
//    }
//    Console.WriteLine("]");
//}

#endregion

#region Combination Sum #39

int[] candidates = [2, 3, 6, 7];
int targetCombination = 7;

var resutlCombinationSum = CombinationSum.CombinationSumMethod(candidates, targetCombination);

//foreach (var combinacao in resutlCombinationSum)
//{
//    Console.Write("[");
//    Console.Write(string.Join(", ", combinacao));
//    Console.WriteLine("]");
//}

#endregion

#region Palindrome Partitioning #131

string sPalindromePart = "aab";
var resultPalindrome = PalindromePartitioning.Partition(sPalindromePart);

//foreach (var combinacao in resultPalindrome)
//{
//    Console.Write("[");
//    Console.Write(string.Join(", ", combinacao));
//    Console.WriteLine("]");
//}

#endregion

#region Symmetric Tree #101

TreeNode rootSymmetric = new TreeNode(1,
    new TreeNode(2, new TreeNode(3), new TreeNode(4)),
    new TreeNode(2, new TreeNode(4), new TreeNode(3))
);

bool resultSymmetric = SymmetricTree.IsSymmetric(rootSymmetric);
//Console.WriteLine($"É simétrica? {resultSymmetric}");


#endregion

#region Path Sum Tree #112

TreeNode rootPathSum = new TreeNode(5,
    new TreeNode(4,
        new TreeNode(11,
            new TreeNode(7),
            new TreeNode(2)
        ),
        null
    ),
    new TreeNode(8,
        new TreeNode(13),
        new TreeNode(4,
            null,
            new TreeNode(1)
        )
    )
);

int targetPathSum = 22;
bool resultPathSum = PathSum.HasPathSum(rootPathSum, targetPathSum);

//Console.WriteLine($"Existe o path sum para o Target {targetPathSum} ? {resultPathSum}");
//Console.WriteLine("Path Sum: ");
//PathSum.ImprimirPathSum(rootPathSum, targetPathSum);

#endregion

#region Lowest Common Ancestor #236

TreeNode node7 = new TreeNode(7);
TreeNode node4 = new TreeNode(4);
TreeNode node2 = new TreeNode(2, node7, node4);
TreeNode node6 = new TreeNode(6);
TreeNode node5 = new TreeNode(5, node6, node2);

TreeNode node0 = new TreeNode(0);
TreeNode node8 = new TreeNode(8);
TreeNode node1 = new TreeNode(1, node0, node8);

TreeNode rootLca = new TreeNode(3, node5, node1);

TreeNode? resultLca = LowestCommonAncestor.LowestCommonAncestorMethod(rootLca, node5, node1);
//Console.WriteLine($"LCA de {node5.val} e {node1.val} é: {resultLca?.val}");

resultLca = LowestCommonAncestor.LowestCommonAncestorMethod(rootLca, node5, node4);
//Console.WriteLine($"LCA de {node5.val} e {node4.val} é: {resultLca?.val}");

#endregion

#region Kth Smallest Element in BST #230

//TreeNode node7Kth = new TreeNode(7);
TreeNode node4Kth = new TreeNode(4);
TreeNode node2Kth = new TreeNode(2);
//TreeNode node6Kth = new TreeNode(6);
//TreeNode node5Kth = new TreeNode(5, node6Kth, node2Kth);

//TreeNode node0Kth = new TreeNode(0);
//TreeNode node8Kth = new TreeNode(8);
TreeNode node1Kth = new TreeNode(1, null, node2Kth);

TreeNode rootKth = new TreeNode(3, node1Kth, node4Kth);

KthElementInBst objKth = new KthElementInBst();

int resultKth = objKth.KthSmallest(rootKth, 1);
//Console.WriteLine(resultKth);

#endregion

#region Binary Tree Maximum Path Sum #124 (Hard)

TreeNode rootMaxPathSum = new TreeNode(1, new TreeNode(2), new TreeNode(3));

int maxPathSum = BinaryTreeMaximumPathSum.MaxPathSum(rootMaxPathSum);
//Console.WriteLine(maxPathSum);

#endregion

#region Min Stack #155

MinStack minStack = new MinStack();

minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);

//Console.WriteLine("Mínimo atual: " + minStack.GetMin()); // -3

minStack.Pop();

//Console.WriteLine("Topo atual: " + minStack.Top());     // 0
//Console.WriteLine("Mínimo atual: " + minStack.GetMin()); // -2

#endregion

#region BinaryTree ZigZag #103

TreeNode rootZigZag = new TreeNode(3,
    new TreeNode(9),
    new TreeNode(20,
        new TreeNode(15),
        new TreeNode(7)
    )
);

var resultZigZag = BinaryTreeZigZag.ZigzagLevelOrder(rootZigZag);

//foreach (var nivel in resultZigZag)
//{
//    Console.WriteLine("[" + string.Join(", ", nivel) + "]");
//}

#endregion

#region Binary Tree Postorder Traversal #145

TreeNode rootPostorder = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5)
    ),
    new TreeNode(3)
);

var resultPostorder = BinaryTreePostOrderTraversal.PostOrderTraversal(rootPostorder);

//Console.WriteLine("[" + string.Join(", ", resultPostorder) + "]");

#endregion 

#region House Robber #198 (Dynamic Programming)

int[] casas = { 2, 7, 9, 3, 1 }; // exemplo clássico

int maximoRoubado = HouseRobber.Rob(casas);

//Console.WriteLine("Máximo que pode ser roubado: " + maximoRoubado);

#endregion

#region Coin Change #322

int[] coins = [1, 2, 5];
int amount = 11;

int resultCoins = CoinChange.CoinChangeMethod(coins, amount);
//Console.WriteLine(resultCoins);

#endregion

#region Unique Paths #62

int mUnique = 3, nUnique = 3;
int resultUniquepaths = UniquePaths.UniquePathsMethod(mUnique, nUnique);
//Console.WriteLine(resultUniquepaths);

#endregion

#region Longest Substring Palindrom #5

string longestPalindrome = "babad";
string resultLongestPalindrome = LongestPalindromeSubstring.LongestPalindrome(longestPalindrome);
//Console.WriteLine(resultLongestPalindrome);

#endregion

#region Trapping Rain Water #42 (Hard)

int[] heightsWater = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
int resultTrapWater = TrappingRainWater.Trap(heightsWater);
//Console.WriteLine(resultTrapWater);

#endregion

#endregion

Console.ReadKey();