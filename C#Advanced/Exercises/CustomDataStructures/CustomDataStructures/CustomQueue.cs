using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class CustomQueue
    {
        private Node _tail;

        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (_tail == null)
            {
                _tail = new Node(element);
            }
            else
            {
                var oldTail = _tail;
                var newTail = new Node(element);
                _tail = newTail;
                _tail.Previous = oldTail;
            }
            Count++;
        }

        public int Dequeue()
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

        public int Peek()
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

        public void ForEach(Action<int> action)
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
