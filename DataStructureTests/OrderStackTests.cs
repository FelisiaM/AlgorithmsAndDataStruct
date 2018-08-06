using System.Collections.Generic;
using DataStructures;
using Xunit;

namespace DataStructureTests
{
    public class OrderStackTests
    {
        [Fact]
        public void Should_ReturnOrderedStack_When_UnorderedStackPassed()
        {
            // [arrange]
            var underTest = new OrderStack();
            
            // [act]
            var stackToOrder = new Stack<int>();
            stackToOrder.Push(0);
            stackToOrder.Push(1);
            stackToOrder.Push(4);
            stackToOrder.Push(4);
            stackToOrder.Push(6);
            stackToOrder.Push(6);
            stackToOrder.Push(5);
            stackToOrder.Push(2);
            stackToOrder.Push(3);
            
            var result = underTest.OrderMinToMax(stackToOrder);
            
            // [assert]
            Assert.Equal(9, result.Count);

            Assert.Equal(0, result.Pop());
            Assert.Equal(1, result.Pop());
            Assert.Equal(2, result.Pop());
            Assert.Equal(3, result.Pop());
            Assert.Equal(4, result.Pop());
            Assert.Equal(4, result.Pop());
            Assert.Equal(5, result.Pop());
            Assert.Equal(6, result.Pop());
            Assert.Equal(6, result.Pop());
        }

        [Fact]
        public void Should_ReturnOrderedStack_When_UnorderedStackWithOneElementPassed()
        {
            // [arrange]
            var underTest = new OrderStack();

            // [act]
            var stackToOrder = new Stack<int>();
            stackToOrder.Push(0);
            var result = underTest.OrderMinToMax(stackToOrder);

            // [assert]
            Assert.Equal(1, result.Count);
            Assert.Equal(0, result.Pop());
        }
    }
}