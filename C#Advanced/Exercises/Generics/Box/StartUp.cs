namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var elements = new List<Box<double>>();

            for (int i = 0; i < count; i++)
            {
                var input = double.Parse(Console.ReadLine());
                elements.Add(new Box<double>(input));
            }

            var elementToCompareTo = double.Parse(Console.ReadLine());

            Console.WriteLine(Box<double>.GetValidElementsCount(elements, elementToCompareTo)); 
        }
    }
}