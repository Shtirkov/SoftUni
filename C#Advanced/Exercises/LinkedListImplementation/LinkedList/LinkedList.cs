namespace LinkedList
{
    public class LinkedList
    {       
        public Node Head { get; set; } = new Node();

        public void AddFirst(int element)
        {
            Head.Next = Head;
            Head.Value = element;
        }
    }
}
