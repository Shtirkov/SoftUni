namespace CustomDataStructures
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            // 1.Testing linked list

            var myList = new CustomLinkedList<string>();
            myList.AddFirst("pesho");
            myList.AddFirst("gosho");
            myList.AddFirst("spas");

            myList.AddLast("ivan");
            myList.AddLast("misho");
            myList.AddLast("stoqn");

            myList.PrintList();

            Console.WriteLine(myList.RemoveFirst());
            Console.WriteLine(myList.RemoveLast());
            Console.WriteLine("======================");

            myList.PrintList();
            Console.WriteLine("======================");

            var arr = myList.ToArray();
            Console.WriteLine(arr.Length);

            myList.ForEach(x => Console.WriteLine(x));


            // 2.Testing custom list

            //var myList = new CustomList<string>();

            //for (int i = 0; i < 16; i++)
            //{
            //    myList.Add($"i = {i}");
            //}

            //var contains = myList.Contains("test");

            //for (int i = 0; i < 2; i++)
            //{
            //    myList.InsertAt(0, "test");
            //}

            //var contains2 = myList.Contains("test");

            //myList.Swap(0, 17);

            //3.Testing custom stack

            //var stack = new CustomStack<char>();
            //var count = stack.Count;
            //stack.Push('a');
            //stack.Push('b');
            //stack.Push('c');
            //stack.Push('d');
            //stack.Push('e');
            //var test = stack.Pop();
            //var test2 = stack.Peek();
            //stack.Peek();
            //stack.Peek();
            //stack.Peek();
            //stack.Peek();
            //var text = "";
            //stack.ForEach(x => text += x);
            //Console.WriteLine(text);

            // 4. Testing custom queue

            //var queue = new CustomQueue<string>();
            //queue.Enqueue("az");
            //queue.Enqueue("ti");
            //queue.Enqueue("toi");
            //queue.Enqueue("toi");
            //queue.Enqueue("toi");
            //var test = queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //var test2 = queue.Peek();
            //var text = "";
            //queue.ForEach(x => text += x);
            //Console.WriteLine(text);
        }
    }
}