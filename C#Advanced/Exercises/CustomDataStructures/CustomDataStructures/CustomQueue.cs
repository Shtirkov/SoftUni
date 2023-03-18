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
    }
}
