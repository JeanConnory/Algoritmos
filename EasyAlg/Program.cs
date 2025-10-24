using EasyAlg;
using EasyAlg.Sorts;
using System.Xml.Linq;

#region Algoritmos de Ordenação (Sort)

#region InsertionSort

int[] numeros = { 5, 3, 4, 1 };
int[] ordenado = InsertionSort.InsertionSortMethod(numeros);

//Console.WriteLine("Array ordenado: " + string.Join(", ", ordenado));
//Console.ReadKey();

#endregion

#region BubbleSort

int[] v = [10, 5, 8, 7, 6];

int[] resultBubbleSort = BubbleSort.AlgoritmoBubbleSort(v);

//resultBubbleSort.ToList().ForEach(n => Console.WriteLine(n));

#endregion

#region SelectionSort

int[] arrSelection = [4, 2, 6, 3, 8];
int[] resultSelection = SelectionSort.Selection(arrSelection);

//resultSelection.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

#endregion

#region QuickSort #75

int[] numsQuick = [4, 2, 8, 7, 1, 5, 3, 6];
int[] resultQuick = QuickSort.QuicksortMethod(numsQuick, 0, numsQuick.Length - 1);

//resultQuick.ToList().ForEach(n => Console.WriteLine(n));

#endregion

#region MergeSort

MergeSort lista = new MergeSort();
lista.Head = new ListNode(4);
lista.Head.next = new ListNode(2);
lista.Head.next.next = new ListNode(5);
lista.Head.next.next.next = new ListNode(1);
lista.Head.next.next.next.next = new ListNode(3);

//Console.WriteLine("Lista original:");
//lista.Exibir();

//lista.Head = lista.MergeSortMethod(lista.Head);

//Console.WriteLine("Lista ordenada:");
//lista.Exibir();

#endregion

#region HeapSort

int[] numerosHeap = { 12, 2, 24, 51, 8, -5 };
HeapSort.HeapSortMethod(numerosHeap);
//Console.WriteLine("Array ordenado: " + string.Join(", ", numerosHeap));
//Console.ReadKey();

#endregion

#endregion

#region Youtube - Jonathan Moura

#region Reverse LinkedList #206

ListNode node5 = new ListNode(5);
ListNode node4 = new ListNode(4, node5);
ListNode node3 = new ListNode(3, node4);
ListNode node2 = new ListNode(2, node3);
ListNode node1 = new ListNode(1, node2);

//Console.WriteLine("Lista original:");
//PrintList(node1);

//ListNode reversed = ReverseLinkedList.ReverseList(node1!);

//Console.WriteLine("Lista invertida:");
//PrintList(reversed);

//static void PrintList(ListNode? head)
//{
//    while (head != null)
//    {
//        Console.Write(head.val + " ");
//        head = head.next;
//    }
//    Console.WriteLine();
//}

//Console.ReadKey();

#endregion

#region First Occurrence String #28

int occurrence = FirstOcurrenceString.StrStr("butsad", "sad");
//Console.WriteLine(occurrence);
//Console.ReadKey();

#endregion

#region Palindrome Number #9

int numPalindrome = 121;
bool isPalindrome = PalindromeNumber.IsPalindrome(numPalindrome);
//Console.WriteLine(isPalindrome);
//Console.ReadKey();

#endregion

#region LinkedList Cycle #141

ListNode nodeCycle1 = new ListNode(3);
ListNode nodeCycle2 = new ListNode(2);
ListNode nodeCycle3 = new ListNode(0);
ListNode nodeCycle4 = new ListNode(-4);
nodeCycle1.next = nodeCycle2;
nodeCycle2.next = nodeCycle3;
nodeCycle3.next = nodeCycle4;
nodeCycle4.next = nodeCycle2;

//Console.WriteLine("Teste com ciclo: " + LinkedListCycle.HasCycle(nodeCycle1));
//Console.ReadKey();

#endregion

#region Plus One #66

//int[] numsPlusOne = [9];
int[] numsPlusOne = [1, 2, 3, 9];
int[] resultPlusOne = PlusOne.PlusOneMethod(numsPlusOne);

//resultPlusOne.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

#endregion

#region ClimbingStairs #70

int nClimbing = 3;
int resultClimbing = ClimbingStairs.ClimbStairsMethod(nClimbing);
//Console.WriteLine(resultClimbing);

#endregion

#region Maximum Depth of Binary Tree #104

TreeNodeEasy root = new TreeNodeEasy(1);
root.left = new TreeNodeEasy(2);
root.right = new TreeNodeEasy(3);
root.left.left = new TreeNodeEasy(4);

int depth = MaximumDepthBinaryTree.MaxDepth(root);
//Console.WriteLine("Profundidade máxima da árvore: " + depth); // Esperado: 3

#endregion

#region Convert sorted Array to BST #108

int[] numsConvert = { -10, -3, 0, 5, 9 };
TreeNodeEasy rootConvert = ConvertSortedArrayToBfs.SortedArrayToBST(numsConvert);

//Console.WriteLine("Árvore gerada (em ordem):");
//ConvertSortedArrayToBfs.PrintInOrder(rootConvert); // Esperado: -10 -3 0 5 9

#endregion

#region Same Tree #100

TreeNodeEasy p = new TreeNodeEasy(1, new TreeNodeEasy(2, new TreeNodeEasy(3)));
TreeNodeEasy q = new TreeNodeEasy(1, new TreeNodeEasy(2, new TreeNodeEasy(3)));

bool resultSameTree = SameTree.IsSameTree(p, q);
//Console.WriteLine(resultSameTree);

#endregion

#region Valid Anagram #242

string s = "anagram";
string t = "nagaram";

bool resultValidAnagram = ValidAnagram.IsAnagram(s, t);
//Console.WriteLine(resultValidAnagram);

#endregion

#endregion

#region Youtube - Galego

#region Reverse Bits #190

int nBit = 43261596;
int bitReverso = ReverseBits.ReverseBitsMethod(nBit);
//Console.WriteLine(bitReverso);

#endregion

#region Valid Palindrome #125

string sPalindrome = "A man, a plan, a canal: Panama";
bool isPalindromeText = ValidPalindrome.IsPalindrome(sPalindrome);

//Console.WriteLine(isPalindromeText);

#endregion

#region Number of Recent Calls #933

RecentCounter recent = new RecentCounter();
//Console.WriteLine(recent.Ping(1));
//Console.WriteLine(recent.Ping(100));
//Console.WriteLine(recent.Ping(3001));
//Console.WriteLine(recent.Ping(3002));

#endregion

#region Middle of Linked List #876

ListNode nodeMiddle6 = new ListNode(6);
ListNode nodeMiddle5 = new ListNode(5, nodeMiddle6);
ListNode nodeMiddle4 = new ListNode(4, nodeMiddle5);
ListNode nodeMiddle3 = new ListNode(3, nodeMiddle4);
ListNode nodeMiddle2 = new ListNode(2, nodeMiddle3);
ListNode nodeMiddle1 = new ListNode(1, nodeMiddle2);

ListNode nodeMiddleResult = MiddleLinkedList.MiddleNode(nodeMiddle1);

//Console.WriteLine(nodeMiddleResult.val);

#endregion

#endregion

#region Udemy

#region MergeSortedArray #88

//Case 1
int[] nums1 = [0, 0, 3, 0, 0, 0, 0, 0, 0];
int m = 3;
int[] nums2 = [-1, 1, 1, 1, 2, 3];
int n = 6;

//Case 2
// int[] nums1 = [0];
// int m = 0; 
// int[] nums2 = [1];
// int n = 1;

MergeSortedArray merged = new MergeSortedArray();
//merged.Merge(nums1, m, nums2, n);
//Console.ReadKey();

#endregion

#region Valid Mountain Array #941

int[] arr = [0, 3, 2, 1];
bool isValidMountain = ValidMountainArray.ValidMountainArrayMethod(arr);

//Console.WriteLine(isValidMountain);
//Console.ReadKey();

#endregion

#region MoveZeroes #283

int[] numsMoveZeroes = [0, 1, 0, 3, 12];
int[] resultMoveZeroes = MoveZeroes.MoveZeroesMethod(numsMoveZeroes);

//resultMoveZeroes.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

#endregion

#region BinarySearch #704
//Usa a solução de dois ponteiros (right e left) percorrendo o array O(log n)

int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int target = 8;

BinarySearch binary = new BinarySearch();
int result = binary.Search(nums, target);
//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region Fibonacci #509

int resultFib = Fibonacci.Fib(8);

//Console.WriteLine(resultFib);
//Console.ReadKey();

#endregion

#region TwoSum #1

int[] numerosTwoSum = { 2, 15, 11, 7 };
int alvo = 9;

int[] resultadoTwoSum = TwoSum.TwoSumMethod(numerosTwoSum, alvo);
//Console.WriteLine($"Índices encontrados: {string.Join(", ", resultadoTwoSum)}");
//Console.ReadKey();

#endregion

#region First Bad Version #278

int firstBadVersion = FirstBadVersion.FirstBadVersionMethod(5);
//Console.WriteLine(firstBadVersion);
//Console.ReadKey();

#endregion

#region Missing Number #268

int[] numsMissingNumber = [9, 6, 4, 2, 3, 5, 7, 0, 1];

int resultMissing = MissingNumber.MissingNumberMethod(numsMissingNumber);
//Console.WriteLine(resultMissing);
//Console.ReadKey();

#endregion

#region Single Number #136

int[] numsSingle = [4, 2, 1, 2, 1];

int singleNumber = SingleNumber.SingleNumberMethod(numsSingle);
int singleNumber2 = SingleNumber.SingleNumberMethod(numsSingle);

//Console.WriteLine($"Numero single metodo 1: {singleNumber}");
//Console.WriteLine($"Numero single metodo 2: {singleNumber2}");
//Console.ReadKey();

#endregion

#region Robot Return to Origin #657

string moves = "UDLRU";
bool resultMoves = RobotReturnOrigin.JudgeCircle(moves);

//Console.WriteLine(resultMoves);
//Console.ReadKey();

#endregion

#region AddBinary #67

string aBinary = "1010";
string bBinary = "1011";

string resultAddBinary = AddBinary.AddBinaryMethod(aBinary, bBinary);

//Console.WriteLine(resultAddBinary);
//Console.ReadKey();

#endregion

#region Contains Duplicate #217

int[] numsContainsDuplicate = [1, 2, 3, 1];
bool resultDuplicate = ContainsDuplicate.ContainsDuplicateMethod(numsContainsDuplicate);
//Console.WriteLine(resultDuplicate);
//Console.ReadKey();

#endregion

#region Majority Element #169

int[] numsMajority = [2, 2, 1, 1, 1, 2, 2];
int numMajority = MajorityElement.MajorityElementMethod(numsMajority);
//Console.WriteLine(numMajority);
//Console.ReadKey();

#endregion

#region Merge Two Sorted List #21

ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

ListNode resultado = MergeTwoSortedList.MergeTwoLists(list1, list2);

//while (resultado != null)
//{
//    Console.Write(resultado.val);
//    if (resultado.next != null) Console.Write(" -> ");
//    resultado = resultado.next!;
//}
//Console.WriteLine();

#endregion

#region Valid Parentheses #20

string sValidParentheses = "{[()]}";
bool isValidParentheses = ValidParentheses.IsValid(sValidParentheses);
//Console.WriteLine(isValidParentheses);

#endregion

#endregion

Console.ReadKey();