using EasyAlg;

//Usa a solução de dois ponteiros (right e left) percorrendo o array O(log n)
#region BinarySearch 

int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int target = 8;

BinarySearch binary = new BinarySearch();
int result = binary.Search(nums, target);
//Console.WriteLine(result);
//Console.ReadKey();

#endregion

#region BubbleSort

int[] v = [10, 5, 8, 7, 6];

int[] resultBubbleSort = BubbleSort.AlgoritmoBubbleSort(v);

resultBubbleSort.ToList().ForEach(n => Console.WriteLine(n));
Console.ReadKey();

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
merged.Merge(nums1, m, nums2, n);
//Console.ReadKey();

#endregion

