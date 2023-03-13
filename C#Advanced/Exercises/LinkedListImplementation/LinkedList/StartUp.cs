namespace LinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList();
            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);

            myList.AddLast(4);
            myList.AddLast(5);
            myList.AddLast(6);

            myList.PrintList();
        }
    }
}