using System;
using System.Collections.Generic;
using DataStructures.LinkedLists;

namespace DataStructures.Trees
{
    public class LinkedListOfBinaryTreeNodes
    {
        public List<LinkedList<int>> ConvertToLinkedLists(BinaryTreeNode root)
        {
            var linkedListNodes = new List<LinkedList<int>>();
            if (root == null)
            {
                return linkedListNodes;
            }

            if (root.LeftNode == null && root.RightNode == null)
            {
                linkedListNodes.Add(new LinkedList<int>(new []{root.Value}));
                return linkedListNodes;
            }

            var currentQueue = new Queue<BinaryTreeNode>();
            currentQueue.Enqueue(root);
                        
            Queue<BinaryTreeNode> nextLinkedLintQueue;

            do
            {
                var headLinkedListNode = new LinkedList<int>();;
                
                var first = currentQueue.Dequeue();
                headLinkedListNode.AddLast(first.Value);

                nextLinkedLintQueue = new Queue<BinaryTreeNode>();

                if (first.LeftNode != null)
                {
                    nextLinkedLintQueue.Enqueue(first.LeftNode);
                }

                if (first.RightNode != null)
                {
                    nextLinkedLintQueue.Enqueue(first.RightNode);
                }

                while (currentQueue.Count != 0)
                {
                    var nextLinkedListNode = new LinkedListNode();
                    var currentNode = currentQueue.Dequeue();
                    nextLinkedListNode.Data = currentNode.Value;

                    headLinkedListNode.AddLast(currentNode.Value);

                    if (currentNode.LeftNode != null)
                    {
                        nextLinkedLintQueue.Enqueue(currentNode.LeftNode);
                    }

                    if (currentNode.RightNode != null)
                    {
                        nextLinkedLintQueue.Enqueue(currentNode.RightNode);
                    }
                }

                linkedListNodes.Add(headLinkedListNode);

                currentQueue = nextLinkedLintQueue;
            } while (nextLinkedLintQueue.Count != 0);

            return linkedListNodes;
        }

        
    }
}