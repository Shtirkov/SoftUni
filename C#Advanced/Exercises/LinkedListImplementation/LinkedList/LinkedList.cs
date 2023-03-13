namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }


        public void AddFirst(int element)
        {
            var newHead = new Node(element);

            if (Head == null)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }

        }

        public void AddLast(int element)
        {
           var newTail = new Node(element);

            if (Tail == null)
            {
                Head = newTail;
                Tail = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
        }

        public int RemoveFirst()
        {
            var oldHead = Head.Value;
            Head = Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public int RemoveLast()
        {
            var oldTail = Tail.Value;
            Tail = Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public void PrintList()
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
