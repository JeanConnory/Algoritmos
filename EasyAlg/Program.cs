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
//Console.ReadKey();

#endregion

#region SelectionSort

int[] arrSelection = [4, 2, 6, 3, 8];
int[] resultSelection = SelectionSort.Selection(arrSelection);

//resultSelection.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

#endregion

#region QuickSort

int[] numsQuick = [4, 2, 8, 7, 1, 5, 3, 6];
int[] resultQuick = QuickSort.QuicksortMethod(numsQuick, 0, numsQuick.Length - 1);

//resultQuick.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

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

//Console.ReadKey();

#endregion

#region HeapSort

int[] numerosHeap = { 12, 2, 24, 51, 8, -5 };
HeapSort.HeapSortMethod(numerosHeap);
//Console.WriteLine("Array ordenado: " + string.Join(", ", numerosHeap));
//Console.ReadKey();

#endregion

#endregion

#region Youtube - Jonathan Moura

#region Reverse LinkedList

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

#region First Occurrence String

int occurrence = FirstOcurrenceString.StrStr("butsad", "sad");
//Console.WriteLine(occurrence);
//Console.ReadKey();

#endregion

#region Palindrome Number

int numPalindrome = 121;
bool isPalindrome = PalindromeNumber.IsPalindrome(numPalindrome);
//Console.WriteLine(isPalindrome);
//Console.ReadKey();

#endregion

#region LinkedList Cycle

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

#endregion

#region Youtube - Galego

#endregion

#region Udemy

#region MergeSortedArray

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

#region Valid Mountain Array

int[] arr = [0, 3, 2, 1];
bool isValidMountain = ValidMountainArray.ValidMountainArrayMethod(arr);

//Console.WriteLine(isValidMountain);
//Console.ReadKey();

#endregion

#region MoveZeroes

int[] numsMoveZeroes = [0, 1, 0, 3, 12];
int[] resultMoveZeroes = MoveZeroes.MoveZeroesMethod(numsMoveZeroes);

//resultMoveZeroes.ToList().ForEach(n => Console.WriteLine(n));
//Console.ReadKey();

#endregion

#region BinarySearch 
//Usa a solução de dois ponteiros (right e left) percorrendo o array O(log n)

int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int target = 8;

BinarySearch binary = new BinarySearch();
int result = binary.Search(nums, target);
//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region Fibonacci

int resultFib = Fibonacci.Fib(8);

//Console.WriteLine(resultFib);
//Console.ReadKey();

#endregion

#region TwoSum

int[] numerosTwoSum = { 2, 15, 11, 7 };
int alvo = 9;

int[] resultadoTwoSum = TwoSum.TwoSumMethod(numerosTwoSum, alvo);
//Console.WriteLine($"Índices encontrados: {string.Join(", ", resultadoTwoSum)}");
//Console.ReadKey();

#endregion

#region First Bad Version

int firstBadVersion = FirstBadVersion.FirstBadVersionMethod(5);
//Console.WriteLine(firstBadVersion);
//Console.ReadKey();

#endregion

#region Missing Number

int[] numsMissingNumber = [9, 6, 4, 2, 3, 5, 7, 0, 1];

int resultMissing = MissingNumber.MissingNumberMethod(numsMissingNumber);
//Console.WriteLine(resultMissing);
//Console.ReadKey();

#endregion

#region Single Number

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

#region AddBinary

string aBinary = "1010";
string bBinary = "1011";

string resultAddBinary = AddBinary.AddBinaryMethod(aBinary, bBinary);

//Console.WriteLine(resultAddBinary);
//Console.ReadKey();

#endregion

#endregion