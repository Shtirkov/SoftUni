﻿namespace CustomDataStructures
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList();
            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);

            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);

            myList.PrintList();
           
            Console.WriteLine(myList.RemoveFirst());
            Console.WriteLine(myList.RemoveLast()); 
            Console.WriteLine("======================");

            myList.PrintList();
            Console.WriteLine("======================");

            var arr = myList.ToArray();
            Console.WriteLine(arr.Length);

            myList.ForEach(x => Console.WriteLine(x));
        }
    }
}