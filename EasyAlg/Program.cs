using EasyAlg;

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
Console.ReadKey();