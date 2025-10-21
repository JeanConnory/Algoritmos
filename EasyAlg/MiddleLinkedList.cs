namespace EasyAlg;

public static class MiddleLinkedList
{
    public static ListNode MiddleNode(ListNode head)
    {
        ListNode ahead = head;

        while (ahead != null && ahead.next != null)
        {
            ahead = ahead.next.next!;
            head = head.next!;
        }
        return head;
    }
}
