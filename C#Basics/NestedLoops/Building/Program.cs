using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCountPerFloor = int.Parse(Console.ReadLine());
            int highestFloor = floorsCount;

            for (int currentFloor = floorsCount; currentFloor >= 1; currentFloor--)
            {
                if (floorsCount == 1)
                {
                    for (int roomNumber = 0; roomNumber < roomsCountPerFloor; roomNumber++)
                    {
                        Console.Write($"L{currentFloor}{roomNumber} ");
                        floorsCount++;
                    }
                    return;
                }

                if (currentFloor % 2 == 0 && currentFloor != highestFloor)
                {

                    for (int roomNumber = 0; roomNumber <= roomsCountPerFloor; roomNumber++)
                    {

                        if (roomNumber == roomsCountPerFloor)
                        {
                            Console.WriteLine("");
                            break;
                        }

                        Console.Write($"O{currentFloor}{roomNumber} ");

                    }

                }
                else if (currentFloor % 2 != 0 && currentFloor != highestFloor)
                {

                    for (int roomNumber = 0; roomNumber <= roomsCountPerFloor; roomNumber++)
                    {
                        if (roomNumber == roomsCountPerFloor)
                        {
                            Console.WriteLine("");
                            break;
                        }

                        Console.Write($"A{currentFloor}{roomNumber} ");
                    }

                }
                else if (currentFloor == highestFloor)
                {
                    for (int roomNumber = 0; roomNumber <= roomsCountPerFloor; roomNumber++)
                    {
                        if (roomNumber == roomsCountPerFloor)
                        {
                            Console.WriteLine("");
                            break;
                        }

                        Console.Write($"L{currentFloor}{roomNumber} ");

                    }

                }
            }
        }
    }
}
