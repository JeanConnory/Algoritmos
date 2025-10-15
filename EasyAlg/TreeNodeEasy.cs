namespace EasyAlg;

public class TreeNodeEasy //Arvore
{
    public int val;
    public TreeNodeEasy? left;
    public TreeNodeEasy? right;

    public TreeNodeEasy(int val = 0, TreeNodeEasy? left = null, TreeNodeEasy? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
