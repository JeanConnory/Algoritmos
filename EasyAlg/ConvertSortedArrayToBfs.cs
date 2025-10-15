namespace EasyAlg;

public static class ConvertSortedArrayToBfs
{
    public static TreeNodeEasy SortedArrayToBST(int[] nums)
    {
        if (nums == null)
            return null!;

        return Recursao(nums, 0, nums.Length - 1);
    }

    public static TreeNodeEasy Recursao(int[] nums, int left, int right)
    {
        if (left > right)
            return null!;

        int mid = left + (right - left) / 2;
        TreeNodeEasy root = new TreeNodeEasy();
        root.val = nums[mid];
        root.left = Recursao(nums, left, mid - 1);
        root.right = Recursao(nums, mid + 1, right);

        return root;
    }

    public static void PrintInOrder(TreeNodeEasy? node)
    {
        if (node == null) return;

        PrintInOrder(node.left);
        Console.Write(node.val + " ");
        PrintInOrder(node.right);
    }
}
