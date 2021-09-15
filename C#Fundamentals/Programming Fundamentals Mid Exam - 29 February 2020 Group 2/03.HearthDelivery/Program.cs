using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HearthDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> neighbourhood = Console.ReadLine().Split('@').ToList();
            string command = Console.ReadLine();
            int visitedHouse = 0;
            int currentHouseResult = 0;


            while (command != "Love!")
            {
                string[] commandToArray = command.Split();
                int length = int.Parse(commandToArray[1]);
                visitedHouse += length;
                //currentHouseResult = int.Parse(neighbourhood[visitedHouse]);


                if (visitedHouse > neighbourhood.Count - 1)
                {
                    visitedHouse = 0;
                }                

                currentHouseResult = int.Parse(neighbourhood[visitedHouse]);

                if (currentHouseResult == 0)
                {
                    Console.WriteLine($"Place {visitedHouse} already had Valentine's day.");
                    command = Console.ReadLine();
                    continue;                   
                }
                else
                {
                    currentHouseResult -= 2;
                    neighbourhood.RemoveAt(visitedHouse);
                    neighbourhood.Insert(visitedHouse, currentHouseResult.ToString());
                }

                // int.Parse(neighbourhood[visitedHouse]) -= 2;

                if (currentHouseResult == 0)
                {
                    Console.WriteLine($"Place {visitedHouse} has Valentine's day.");
                }

                command = Console.ReadLine();
            }
           
            bool isTheMissionPassed = true;
            int numberOfFailedPlaces = 0;
            for (int i = 0; i < neighbourhood.Count; i++)
            {
                if (int.Parse(neighbourhood[i]) != 0)
                {
                    isTheMissionPassed = false;
                    numberOfFailedPlaces++;
                }
            }

            Console.WriteLine($"Cupid's last position was {visitedHouse}.");

            if (isTheMissionPassed == true)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {numberOfFailedPlaces} places.");
            }


        }
    }
}
