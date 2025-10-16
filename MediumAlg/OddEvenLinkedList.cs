using EasyAlg;

namespace MediumAlg;

public static class OddEvenLinkedList
{
    public static ListNode OddEvenListMethod(ListNode head)
    {
        if (head == null)
            return head!;

        ListNode temp = head;
        ListNode odd = temp;
        ListNode even = odd.next!;
        ListNode evenList = even;

        while(even != null && even.next != null)
        {
            odd.next = even.next!;
            odd = odd.next!;

            even.next = odd.next!;
            even = even.next!;
        }

        odd.next = evenList;

        return temp;
    }
}
