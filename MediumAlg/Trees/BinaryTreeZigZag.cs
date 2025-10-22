namespace MediumAlg.Trees;

public static class BinaryTreeZigZag
{
    public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if(root == null)
            return new List<IList<int>>();

        List<IList<int>> ans = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int levelIndex = 1;

        while (q.Count > 0)
        {
            List<int> level = new List<int>();
            int qLen = q.Count;

            for (int i = 0; i < qLen; i++)
            {
                TreeNode current = q.Dequeue();
                level.Add(current.val);

                if(current.left != null)
                {
                    q.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    q.Enqueue(current.right);
                }
            }

            if(levelIndex % 2 == 0)
            {
                level.Reverse();
            }

            ans.Add(level);
            levelIndex++;
        }
        return ans;
    }
}
