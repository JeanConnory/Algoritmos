using EasyAlg;

namespace MediumAlg;

public static class AddTwoNumbers
{
    public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode pointer = result;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int i1 = 0, i2 = 0;

            if (l1 != null)
                i1 = l1.val;
            if (l2 != null)
                i2 = l2.val;

            int soma = i1 + i2 + carry;
            carry = soma / 10;

            ListNode newNode = new ListNode();
            newNode.val = soma % 10;
            pointer.next = newNode;

            if (l1 != null)
                l1 = l1.next!;
            if (l2 != null)
                l2 = l2.next!;
            pointer = pointer.next!;
        }

        if (carry > 0)
        {
            ListNode newNode = new ListNode();
            newNode.val = 1;

            pointer.next = newNode;
            pointer = pointer.next!;
        }

        return result.next!;
    }
}
