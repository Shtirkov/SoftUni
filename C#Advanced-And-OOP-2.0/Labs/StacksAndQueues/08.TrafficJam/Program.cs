namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfPassingCars = int.Parse(Console.ReadLine());
            var car = Console.ReadLine();
            var carsQueue = new Queue<string>();
            var counter = 0;

            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < numberOfPassingCars; i++)
                    {
                        if (carsQueue.Count == 0)
                            break;                        

                        counter++;
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                    }
                    car = Console.ReadLine();
                }
                else
                {
                    carsQueue.Enqueue(car);
                    car = Console.ReadLine();
                }                
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}