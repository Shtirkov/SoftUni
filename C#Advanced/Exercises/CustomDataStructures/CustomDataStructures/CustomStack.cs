using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class CustomStack<T>
    {
        private Node<T> _head;

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (_head == null)
            {
                _head = new Node<T>(element);
            }
            else
            {
                var oldHead = _head;
                _head = new Node<T>(element);
                _head.Next = oldHead;
            }
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            else
            {
                var oldHead = _head;
                var newHead = _head.Next;
                _head = newHead;
                Count--;
                return oldHead.Value;
            }
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            else
            {
                return _head.Value;
            }
        }

        public void ForEach(Action<T> action)
        {
            var currentHead = _head;

            while (currentHead != null)
            {
                action(currentHead.Value);
                currentHead = currentHead.Next;
            }

        }
    }
}
