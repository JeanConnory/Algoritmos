using EasyAlg;
using EasyAlg.Sorts;
using System.Xml.Linq;

//Usa a solução de dois ponteiros (right e left) percorrendo o array O(log n)
#region BinarySearch 

int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int target = 8;

BinarySearch binary = new BinarySearch();
int result = binary.Search(nums, target);
//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region TwoSum

int[] numerosTwoSum = { 2, 15, 11, 7 };
int alvo = 9;

int[] resultadoTwoSum = TwoSum.TwoSumMethod(numerosTwoSum, alvo);
//Console.WriteLine($"Índices encontrados: {string.Join(", ", resultadoTwoSum)}");
//Console.ReadKey();

#endregion

#region Fibonacci

int resultFib = Fibonacci.Fib(8);

//Console.WriteLine(resultFib);
//Console.ReadKey();

#endregion

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
int[] resultQuick =  QuickSort.QuicksortMethod(numsQuick, 0, numsQuick.Length - 1);

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

#region MergeSortedArray

//Case 1
int[] nums1 = [0,0,3,0,0,0,0,0,0];
int m = 3; 
int[] nums2 = [-1,1,1,1,2,3];
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

#region First Bad Version

int firstBadVersion = FirstBadVersion.FirstBadVersionMethod(5);
//Console.WriteLine(firstBadVersion);
//Console.ReadKey();

#endregion