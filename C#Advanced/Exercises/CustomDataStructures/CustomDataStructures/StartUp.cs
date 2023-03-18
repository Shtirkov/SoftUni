namespace CustomDataStructures
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //var myList = new LinkedList();
            //myList.AddFirst(1);
            //myList.AddFirst(2);
            //myList.AddFirst(3);

            //myList.AddLast(1);
            //myList.AddLast(2);
            //myList.AddLast(3);

            //myList.PrintList();

            //Console.WriteLine(myList.RemoveFirst());
            //Console.WriteLine(myList.RemoveLast()); 
            //Console.WriteLine("======================");

            //myList.PrintList();
            //Console.WriteLine("======================");

            //var arr = myList.ToArray();
            //Console.WriteLine(arr.Length);

            //myList.ForEach(x => Console.WriteLine(x));

            //var myList = new CustomList();

            //for (int i = 0; i < 16; i++)
            //{
            //    myList.Add(i+1);
            //}

            //var contains = myList.Contains(5);

            //for (int i = 0; i < 2; i++)
            //{
            //    myList.InsertAt(0, i);
            //} 

            //myList.Swap(0,17);


            var stack = new CustomStack();
            var count = stack.Count;
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Count);
        }
    }
}