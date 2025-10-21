namespace EasyAlg
{
    public class ListNode //LinkedList
    {
        public int val;
        public ListNode? next;
        //public ListNode? prev; Doubly LinkedList duplamente ligada head e tail

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
