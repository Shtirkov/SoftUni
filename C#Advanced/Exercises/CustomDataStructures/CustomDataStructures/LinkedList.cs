using CustomDataStructures.Common;

namespace CustomDataStructures
{
    public class LinkedList
    {
    //    public Node Head { get; set; }

    //    public Node Tail { get; set; }

    //    public int Count { get; set; }


    //    public void AddFirst(int element)
    //    {
    //        var newHead = new Node(element);

    //        if (Head == null)
    //        {
    //            Head = newHead;
    //            Tail = newHead;
    //        }
    //        else
    //        {
    //            newHead.Next = Head;
    //            Head.Previous = newHead;
    //            Head = newHead;
    //        }
    //        Count++;
    //    }

    //    public void AddLast(int element)
    //    {
    //        var newTail = new Node(element);

    //        if (Tail == null)
    //        {
    //            Head = newTail;
    //            Tail = newTail;
    //        }
    //        else
    //        {
    //            newTail.Previous = Tail;
    //            Tail.Next = newTail;
    //            Tail = newTail;
    //        }
    //        Count++;
    //    }

    //    public int RemoveFirst()
    //    {
    //        var oldHead = Head.Value;
    //        Head = Head.Next;
    //        Head.Previous = null;
    //        Count--;
    //        return oldHead;
    //    }

    //    public int RemoveLast()
    //    {
    //        var oldTail = Tail.Value;
    //        Tail = Tail.Previous;
    //        Tail.Next = null;
    //        Count--;
    //        return oldTail;
    //    }

    //    public void ForEach(Action<int> action)
    //    {
    //        var currentNode = Head;

    //        while (currentNode != null)
    //        {
    //            action(currentNode.Value);
    //            currentNode = currentNode.Next;
    //        }
    //    }

    //    public int[] ToArray()
    //    {
    //        var array = new int[Count];
    //        var currentNode = Head;

    //        for (int i = 0; i < Count; i++)
    //        {
    //            array[i] = currentNode.Value;
    //            currentNode = currentNode.Next;
    //        }

    //        return array;
    //    }

    //    public void PrintList()
    //    {
    //        var currentNode = Head;

    //        while (currentNode != null)
    //        {
    //            Console.WriteLine(currentNode.Value);
    //            currentNode = currentNode.Next;
    //        }
    //    }
    }
}
