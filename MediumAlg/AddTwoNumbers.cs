using EasyAlg;

namespace MediumAlg;

public static class AddTwoNumbers
{
    public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
    {
        ListNode dummyNode = new ListNode();
        ListNode l3 = dummyNode;
        int temp = 0;

        while (l1 != null || l2 != null)
        {
            int i1 = 0, i2 = 0;

            if (l1 != null)
                i1 = l1.val;
            if (l2 != null)
                i2 = l2.val;

            int soma = i1 + i2 + temp;
            temp = soma / 10;

            ListNode newNode = new ListNode();
            newNode.val = soma % 10;
            l3.next = newNode;

            if (l1 != null)
                l1 = l1.next!;
            if (l2 != null)
                l2 = l2.next!;
            l3 = l3.next!;
        }

        if (temp > 0)
        {
            ListNode newNode = new ListNode();
            newNode.val = 1;

            l3.next = newNode;
            l3 = l3.next!;
        }

        return dummyNode.next!;
    }
}
