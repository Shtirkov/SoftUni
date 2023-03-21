using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public int Count { get; set; }


        public void AddFirst(T element)
        {
            var newHead = new Node<T>(element);

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
            Count++;
        }

        public void AddLast(T element)
        {
            var newTail = new Node<T>(element);

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
            Count++;
        }

        public T RemoveFirst()
        {
            var oldHead = Head.Value;
            Head = Head.Next;
            Head.Previous = null;
            Count--;
            return oldHead;
        }

        public T RemoveLast()
        {
            var oldTail = Tail.Value;
            Tail = Tail.Previous;
            Tail.Next = null;
            Count--;
            return oldTail;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public T[] ToArray()
        {
            var array = new T[Count];
            var currentNode = Head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return array;
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
