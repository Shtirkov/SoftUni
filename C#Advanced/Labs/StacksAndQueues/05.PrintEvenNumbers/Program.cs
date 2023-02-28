namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbersQueue = new Queue<int>(numbersArr);
            var result = new List<int>();
           
            while (numbersQueue.Count != 0)
            {
                var currentNumber = numbersQueue.Dequeue();
                if (currentNumber % 2 == 0)
                {
                   result.Add(currentNumber);
                }
            }
            Console.Write(String.Join(", ", result));
        }
    }
}