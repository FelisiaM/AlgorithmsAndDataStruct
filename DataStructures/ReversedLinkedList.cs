namespace DataStructures
{
    public class ReversedLinkedList
    {
        public LinkedListNode ReverseLinkedList(LinkedListNode old)
        {
            var reversedLinkedList = new LinkedListNode
            {
                Data = old.Data
            };

            while (old != null && old.Next != null)
            {
                old = old.Next;
                var temp = new LinkedListNode();
                temp.Data = old.Data;
                temp.Next = reversedLinkedList;
                reversedLinkedList = temp;
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
