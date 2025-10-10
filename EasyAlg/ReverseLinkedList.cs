namespace EasyAlg;

public static class ReverseLinkedList
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode? prev = null;

        while(head != null)
        {
            ListNode next_node = head.next!;
            head.next = prev;
            prev = head;
            head = next_node!;
        }

        return prev!;
    }
}
