using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();
            string username = "";
            string licensePlateNumber = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputToArray = input.Split();
                string command = inputToArray[0];
                 username = inputToArray[1];

                if (command == "register")
                {
                     licensePlateNumber = inputToArray[2];

                    if (!parkingLot.ContainsKey(username))
                    {
                        parkingLot.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingLot.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var car in parkingLot)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
