namespace DataStructures.LinkedLists
{
    public class ReversedLinkedList
    {
        public LinkedListNode ReverseLinkedList(LinkedListNode old)
        {
            if (old == null ||
               (old.Data == null && old.Next == null))
            {
                return old;
            }

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
}
