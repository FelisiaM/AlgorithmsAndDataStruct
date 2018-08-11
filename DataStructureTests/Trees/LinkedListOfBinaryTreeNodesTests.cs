using System.Resources;
using DataStructures.Trees;
using Xunit;

namespace DataStructureTests.Trees
{
    public class LinkedListOfBinaryTreeNodesTests
    {
        //ConvertToLinkedLists

        [Fact]
        public void Should_CreateListOfLinkedLists_When_Called()
        {
            // [arrange]
            var binaryTree = new BinaryTreeNode(6)
            {
                LeftNode = new BinaryTreeNode(3)
                {
                    LeftNode = new BinaryTreeNode(1)
                },
                RightNode = new BinaryTreeNode(5)
                {
                    LeftNode = new BinaryTreeNode(4),
                    RightNode = new BinaryTreeNode(2)
                }
            };
            
            var underTest = new LinkedListOfBinaryTreeNodes();
            
            // [act]
            var result = underTest.ConvertToLinkedLists(binaryTree);

            // [assert]
            Assert.NotNull(result);
            Assert.Equal(6, result[0].First.Value);
            Assert.Equal(3, result[1].First.Value);
            Assert.Equal(5, result[1].First.Next.Value);
            Assert.Equal(1, result[2].First.Value);
            Assert.Equal(4, result[2].First.Next.Value);
            Assert.Equal(2, result[2].First.Next.Next.Value);
        }

    }
}