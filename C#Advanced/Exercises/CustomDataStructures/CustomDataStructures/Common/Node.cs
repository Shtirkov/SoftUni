namespace CustomDataStructures.Common
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }

        public T Value { get; set; }
    }
}
