namespace MediumAlg;

public static class CopyListRandomPointer
{
    public static Node CopyRandomList(Node head)
    {
        if (head == null)
            return head!;

        Node curr = head;
        
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        while (curr != null)
        {
            dict[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;

        while (curr != null)
        {
            dict[curr].next = curr.next != null ? dict[curr.next] : null!;
            dict[curr].random = curr.random != null ? dict[curr.random] : null!;
            curr = curr.next!;
        }

        return dict[head];
    }
}
