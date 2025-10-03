
using System.Xml.Linq;

namespace EasyAlg.Sorts;

public class MergeSort
{
    public ListNode? Head;

    public ListNode MergeSortMethod(ListNode head)
    {
        if (head == null || head.next == null)
            return head!;

        ListNode middle = EncontrarMiddle(head);
        ListNode middleRight = middle.next!;
        middle.next = null;

        ListNode left = MergeSortMethod(head);
        ListNode right = MergeSortMethod(middleRight);

        return Mesclar(left, right);
    }

    private ListNode EncontrarMiddle(ListNode head)
    {
        if(head == null)
            return head!;

        ListNode slow = head!;
        ListNode fast = head.next!;

        while (fast != null && fast.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next!;
        }

        return slow;
    }

    private ListNode Mesclar(ListNode left, ListNode right)
    {
        if (left == null)
            return right;
        if (right == null)
            return left;

        ListNode result;

        if (left.val <= right.val)
        {
            result = left;
            result.next = Mesclar(left.next!, right);
        }
        else
        {
            result = right;
            result.next = Mesclar(left, right.next!);
        }

        return result;
    }

    public void Exibir()
    {
        ListNode? atual = Head;
        while (atual != null)
        {
            Console.Write(atual.val + " ");
            atual = atual.next!;
        }
        Console.WriteLine();
    }
}
