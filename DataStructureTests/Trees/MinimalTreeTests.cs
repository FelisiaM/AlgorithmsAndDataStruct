using System.Collections.Generic;
using DataStructures.Trees;
using Xunit;

namespace DataStructureTests.Trees
{
    public class MinimalTreeTests
    {
        [Fact]
        public void Should_CreateTreeWithMinimalHight_When_ArrayHasEvenNumberOfElements()
        {
            // [arrange]
            
            var underTest = new MinimalTree();
            
            // [act]
            var result = underTest.BuildFromSortedArray(new List<int>() {1, 3, 4, 6, 7, 8, 9});
            
            // [assert]
            Assert.NotNull(result);
            Assert.Equal(6, result.Value);
            Assert.Equal(3, result.LeftNode.Value);
            Assert.Equal(1, result.LeftNode.LeftNode.Value);
            Assert.Equal(4, result.LeftNode.RightNode.Value);
            Assert.Equal(8, result.RightNode.Value);
            Assert.Equal(7, result.RightNode.LeftNode.Value);
            Assert.Equal(9, result.RightNode.RightNode.Value);
        }
        
        [Fact]
        public void Should_CreateTreeWithMinimalHight_When_ArrayHasOddNumberOrElements()
        {
            // [arrange]
            
            var underTest = new MinimalTree();
            
            // [act]
            var result = underTest.BuildFromSortedArray(new List<int>() {1, 3, 4, 6, 7, 8});
            
            // [assert]
            Assert.NotNull(result);
            Assert.Equal(6, result.Value);
            Assert.Equal(3, result.LeftNode.Value);
            Assert.Equal(1, result.LeftNode.LeftNode.Value);
            Assert.Equal(4, result.LeftNode.RightNode.Value);
            Assert.Equal(8, result.RightNode.Value);
            Assert.Equal(7, result.RightNode.LeftNode.Value);
        }
        
    }
}