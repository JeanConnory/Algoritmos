using EasyAlg;

namespace MediumAlg;

public static class RemoveNthElementFromEnd
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode temp = new ListNode();
        temp.next = head;
        ListNode slow = temp;
        ListNode fast = temp.next;

        for (int i = 0; i < n; i++)
        {
            fast = fast.next!;
        }

        while(fast != null)
        {
            fast = fast.next!;
            slow = slow.next!;
        }
        slow.next = slow.next!.next;
        return temp.next;
    }
}
