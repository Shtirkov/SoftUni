namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split();
            var command = inputArr[0];
            var elements = inputArr.Skip(1).ToList();
            var collection = new ListyIterator<string>(elements);

            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(collection.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(collection.Move());
                        break;
                    case "Print":
                        try
                        {
                            collection.Print();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}