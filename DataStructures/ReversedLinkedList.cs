namespace DataStructures
{
    public class ReversedLinkedList
    {
        public LinkedListNode ReverseLinkedList(LinkedListNode old)
        {
            var reversedLinkedList = new LinkedListNode();
            reversedLinkedList.Data = old.Data;

            while (old != null && old.Next != null)
            {
                old = old.Next;
                var t = new LinkedListNode();
                t.Data = old.Data;
                t.Next = reversedLinkedList;
                reversedLinkedList = t;
            }

            return reversedLinkedList;
        }
    }

    public class LinkedListNode
    {
        public LinkedListNode Next { get; set; }
        public int Data { get; set; }
    }
}
