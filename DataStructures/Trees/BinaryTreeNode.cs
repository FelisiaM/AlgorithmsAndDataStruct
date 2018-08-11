namespace DataStructures.Trees
{
    public class BinaryTreeNode
    {
        public int Value { get; }

        public bool Visited { get; set; }

        public BinaryTreeNode LeftNode { get; set; }

        public BinaryTreeNode RightNode { get; set; }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}