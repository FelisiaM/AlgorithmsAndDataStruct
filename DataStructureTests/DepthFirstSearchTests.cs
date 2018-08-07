using System;
using DataStructures.Trees;
using Xunit;

namespace DataStructureTests
{
    public class DepthFirstSearchTests
    {
        [Fact]
        public void Should_TraverseAllNodesInDepthFirstOrder_When_Called()
        {
            // [arrange]
            var node0 = new Node("0");
            var node1 = new Node("1");
            var node2 = new Node("2");
            var node3 = new Node("3");
            var node4 = new Node("4");
            var node5 = new Node("5");

            node0.Children = new Node[] { node1, node4, node5 };
            node1.Children = new Node[] { node3, node4 };
            node3.Children = new Node[] { node1, node2, node4 };

            var graph = new Node[]{
                node0, node1, node2, node3, node4, node5
            };

            var underTest = new DepthFirstSearch();

            // [act]
            underTest.TraverseAndPrint(node0);

            // [assert]
            Assert.Equal("0", underTest.DfsOrderedList[0]);
            Assert.Equal("1", underTest.DfsOrderedList[1]);
            Assert.Equal("3", underTest.DfsOrderedList[2]);
            Assert.Equal("2", underTest.DfsOrderedList[3]);
            Assert.Equal("4", underTest.DfsOrderedList[4]);
            Assert.Equal("5", underTest.DfsOrderedList[5]);
        }
    }
}
