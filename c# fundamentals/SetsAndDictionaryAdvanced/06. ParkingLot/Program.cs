using System;
using System.Collections.Generic;

namespace _06._ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string command = input.Split(", ")[0];
                string car = input.Split(", ")[1];

                if (command == "IN")
                {
                    parkingLot.Add(car);
                }
                else if (command == "OUT")
                {
                    parkingLot.Remove(car);
                }
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
