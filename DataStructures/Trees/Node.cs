namespace DataStructures.Trees
{
    public class Node
    {
        public string Name { get; }

        public bool Visited { get; set; }
        public Node[] Children { get; set; }

        public Node(string name)
        {
            Name = name;
        }
    }
}