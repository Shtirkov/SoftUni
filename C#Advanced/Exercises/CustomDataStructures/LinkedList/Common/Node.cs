namespace CustomDataStructures.Common
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public int Value { get; set; }
    }
}
