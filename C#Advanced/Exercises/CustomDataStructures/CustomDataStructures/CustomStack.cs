﻿using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class CustomStack
    {
        private Node _head;

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (_head == null)
            {
                _head = new Node(element);
            }
            else
            {
                var oldHead = _head;
                _head = new Node(element);
                _head.Next = oldHead;
            }
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack contains no elements!");
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
    }
}
