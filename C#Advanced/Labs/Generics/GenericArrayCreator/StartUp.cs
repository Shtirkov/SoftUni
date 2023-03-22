namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myArr = ArrayCreator.Create(5, "pesho");
            Console.WriteLine(string.Join(", ", myArr));
        }
    }
}