using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfThePassengersAtTheStart = int.Parse(Console.ReadLine());
            int numberOfStops = int.Parse(Console.ReadLine());
            int totalPassengers = 0;

            for (int currentStop = 1; currentStop <= numberOfStops; currentStop++)
            {
                int passengersThatTookOffTheBus = int.Parse(Console.ReadLine());
                int newPassengers = int.Parse(Console.ReadLine());

                if (currentStop % 2 != 0 && currentStop == 1)
                {
                    totalPassengers = numberOfThePassengersAtTheStart + newPassengers - passengersThatTookOffTheBus + 2;
                }
                else if (currentStop % 2 == 0 && currentStop == 1)
                {
                    totalPassengers = numberOfThePassengersAtTheStart + newPassengers - passengersThatTookOffTheBus - 2;
                }
                else if (currentStop % 2 != 0 && currentStop != 1)
                {
                    totalPassengers = totalPassengers + newPassengers - passengersThatTookOffTheBus + 2;
                }
                else if (currentStop % 2 == 0 && currentStop != 1)
                {
                    totalPassengers = totalPassengers + newPassengers - passengersThatTookOffTheBus - 2;
                }

            }
            Console.WriteLine($"The final number of passengers is : {totalPassengers}");
        }
    }
}
