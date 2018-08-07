using System;
namespace DataStructures.Trees
{
    public class Node
    {
        public string Name { get; set; }
        public bool Visited { get; set; }
        public Node[] Children { get; set; }

        public Node(string name)
        {
            Name = name;
        }
    }

    public class Graph
    {
        public Node[] Nodes { get; set; }   
    }
}
