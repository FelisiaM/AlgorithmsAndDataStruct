using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    /// <summary>
    /// Breadth first search.
    /// Start at the root (or another arbitrarily selected node) and explore each
    /// neighbor before going on to any of their children
    /// </summary>
    public class BreadthFirstSearch
    {
        public List<string> BfsOrderedList { get; set; }

        public BreadthFirstSearch()
        {
            BfsOrderedList = new List<string>();
        }

        public void TraverseAndPrint(Node root)
        {

            if (root == null)
            {
                return;
            }

            var queue = new Queue<Node>();

            root.Visited = true;
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                BfsOrderedList.Add(current.Name);
                Console.WriteLine(current.Name);

                if (current.Children != null)
                {
                    foreach (var node in current.Children)
                    {
                        if (!node.Visited)
                        {
                            node.Visited = true;
                            queue.Enqueue(node);
                        }
                    }
                }
            }
        }
    }
}
