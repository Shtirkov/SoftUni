using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class CustomQueue<T>
    {
        private Node<T> _tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (_tail == null)
            {
                _tail = new Node<T>(element);
            }
            else
            {
                var oldTail = _tail;
                var newTail = new Node<T>(element);
                _tail = newTail;
                _tail.Previous = oldTail;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            else
            {
                var oldTail = _tail;
                var newTail = _tail.Previous;
                _tail = newTail;
                Count--;
                return oldTail.Value;
            }
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            else
            {
                return _tail.Value;
            }
        }

        public void ForEach(Action<T> action)
        {
            var currentTail = _tail;

            while (currentTail != null)
            {
                action(currentTail.Value);
                currentTail = currentTail.Previous;
            }
        }
    }
}
