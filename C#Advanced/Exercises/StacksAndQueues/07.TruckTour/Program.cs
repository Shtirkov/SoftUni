namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var petrolPumpsCount = int.Parse(Console.ReadLine());
            var queuedPetrolPumps = new Queue<string>();
            var tankCapacity = 0;

            for (int i = 0; i < petrolPumpsCount; i++)
            {
                var petrolPump = $"{Console.ReadLine()} {i}";
                queuedPetrolPumps.Enqueue(petrolPump);
            }

            for (int i = 0; i < petrolPumpsCount; i++)
            {
                var currentPumpInformation = queuedPetrolPumps.Dequeue();
                var fuelInCurrentPump = int.Parse(currentPumpInformation.Split(' ')[0]);
                var distanceToNextPump = int.Parse(currentPumpInformation.Split(' ')[1]);
                tankCapacity += fuelInCurrentPump;

                if (tankCapacity < distanceToNextPump)
                {
                    tankCapacity = 0;
                    i = -1;
                }
                else
                {
                    tankCapacity -= distanceToNextPump;
                }

                queuedPetrolPumps.Enqueue(currentPumpInformation);
            }

            Console.WriteLine(queuedPetrolPumps.Dequeue().Split(' ')[2]);
        }
    }
}