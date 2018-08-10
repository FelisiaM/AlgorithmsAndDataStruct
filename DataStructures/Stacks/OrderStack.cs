using System.Collections.Generic;

namespace DataStructures.Stacks
{
    public class OrderStack
    {
        public Stack<int> OrderMinToMax(Stack<int> stackToOrder)
        {
            var orderedStack = new Stack<int>();
            if (stackToOrder.Count < 1 )
            {
                return stackToOrder;
            }
            
            orderedStack.Push(stackToOrder.Pop());
            while (stackToOrder.Count != 0)
            {
                var element = stackToOrder.Pop();

                if (element <= orderedStack.Peek())
                {
                    orderedStack.Push(element);
                }
                else
                {
                    while (orderedStack.Count > 0 && 
                           orderedStack.Peek() <= element)
                    {
                        stackToOrder.Push(orderedStack.Pop());
                    }
                    orderedStack.Push(element);
                }
            }

            return orderedStack;
        }
    }
}