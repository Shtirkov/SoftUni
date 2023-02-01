using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            string filmName = Console.ReadLine();

            int totalStudent = 0;
            int totalStandart = 0;
            int totalKids = 0;
            int totalTickets = 0;
            
            while (filmName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int studentCounter = 0;
                int standartCounter = 0;
                int kidsCounter = 0;


                for (int currentSeat = 1; currentSeat <= freeSeats; currentSeat++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "student")
                    {
                        studentCounter++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsCounter++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }
                }
                totalKids += kidsCounter;
                totalStandart += standartCounter;
                totalStudent += studentCounter;
                totalTickets = totalStudent + totalStandart + totalKids;


                Console.WriteLine($"{filmName} - {(double)(studentCounter + standartCounter + kidsCounter) / freeSeats * 100:f2}% full.");
                filmName = Console.ReadLine();
            }
            if (filmName == "Finish")
            {
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{totalStudent /(double) totalTickets * 100:f2}% student tickets.");
                Console.WriteLine($"{totalStandart / (double)totalTickets * 100:f2}% standard tickets.");
                Console.WriteLine($"{totalKids / (double)totalTickets * 100:f2}% kids tickets.");
            }
        }
    }
}
