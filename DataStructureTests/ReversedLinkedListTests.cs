using DataStructures;
using Xunit;

namespace DataStructureTests
{
    public class ReversedLinkedListTests
    {
        [Fact]
        public void Should_ReturnReversedLinkedList_When_LinkedListIsPassed()
        {
            // [arrange]
            var underTest = new ReversedLinkedList();
            var input = new LinkedListNode()
            {
                Data = 0,
                Next = new LinkedListNode()
                {
                    Data = 0,
                    Next = new LinkedListNode()
                    {
                        Data = 1,
                        Next = new LinkedListNode()
                        { Data = 2 }
                    }
                }
            };

            // [act]
            var result = underTest.ReverseLinkedList(input);

            // [assert]
            Assert.Equal(input.Next.Next.Next.Data, result.Data);
            Assert.Equal(input.Next.Next.Data, result.Next.Data);
            Assert.Equal(input.Next.Data, result.Next.Next.Data);
            Assert.Equal(input.Data, result.Next.Next.Next.Data);
        }

        [Fact]
        public void Should_ReturnReversedLinkedList_When_LinkedListWithOneItemIsPassed()
        {
            // [arrange]
            var underTest = new ReversedLinkedList();
            var input = new LinkedListNode()
            {
                Data = 9
            };

            // [act]
            var result = underTest.ReverseLinkedList(input);

            // [assert]
            Assert.Equal(input.Data, result.Data);
            Assert.Null(result.Next);
        }
    }
}
