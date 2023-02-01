namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var greenLightDuration = int.Parse(Console.ReadLine());
            var freeWindowDuration = int.Parse(Console.ReadLine());
            var queuedCars = new Queue<string>();
            var command = Console.ReadLine();
            var totalCarsPassed = 0;

            while (command != "END")
            {
                if (command == "green" && queuedCars.Count > 0)
                {
                    var currentCar = queuedCars.Dequeue();
                    var notModifiedCurrentCar = currentCar;
                    var carHasPassed = false;

                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        currentCar = currentCar.Remove(0, 1);

                        if (currentCar.Length == 0)
                        {
                            totalCarsPassed++;
                            carHasPassed = true;

                            if (queuedCars.Count > 0 && i < greenLightDuration - 1)
                            {
                                currentCar = queuedCars.Dequeue();
                                carHasPassed = false;
                                notModifiedCurrentCar = currentCar;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    for (int i = 0; i < freeWindowDuration; i++)
                    {
                        if (currentCar.Length != 0)
                        {
                            currentCar = currentCar.Remove(0, 1);
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (!carHasPassed && currentCar.Length == 0)
                    {
                        totalCarsPassed++;
                    }
                    else if (currentCar.Length != 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{notModifiedCurrentCar} was hit at {currentCar[0]}.");
                        return;
                    }
                }
                else
                {
                    queuedCars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}