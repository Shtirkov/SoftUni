namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList() { "az", "ti", "toi", "tq", "to"};
            Console.WriteLine(list.RandomString());
        }
    }
}