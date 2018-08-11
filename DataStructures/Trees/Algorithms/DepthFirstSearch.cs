using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    /// <summary>
    /// Recursive search
    /// Visit a node root and then iterate through each of root's neighbors.
    /// </summary>
    public class DepthFirstSearch
    {
        public List<string> DfsOrderedList { get; set; }

        public DepthFirstSearch()
        {
            DfsOrderedList = new List<string>();
        }

        public void TraverseAndPrint(Node root)
        {
            if (root == null)
            {
                return;
            }

            DfsOrderedList.Add(root.Name);
            Console.WriteLine(root.Name);
            root.Visited = true;

            if (root.Children != null)
            {
                foreach (var n in root.Children)
                {
                    if (!n.Visited)
                    {
                        TraverseAndPrint(n);
                    }
                }
            }
        }
    }
}
