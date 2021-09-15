using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string periodOfTheHoliday = Console.ReadLine();
            int sleepOversCount = int.Parse(Console.ReadLine());
            double priceForASingleNight = 0;

            switch (destination)
            {
                case "France":
                    if (periodOfTheHoliday == "21-23")
                    {
                        priceForASingleNight = 30;
                    }
                    else if (periodOfTheHoliday == "24-27")
                    {
                        priceForASingleNight = 35;
                    }
                    else if (periodOfTheHoliday == "28-31")
                    {
                        priceForASingleNight = 40;
                    }
                    break;
                case "Italy":
                    if (periodOfTheHoliday == "21-23")
                    {
                        priceForASingleNight = 28;
                    }
                    else if (periodOfTheHoliday == "24-27")
                    {
                        priceForASingleNight = 32;
                    }
                    else if (periodOfTheHoliday == "28-31")
                    {
                        priceForASingleNight = 39;
                    }
                    break;
                case "Germany":
                    if (periodOfTheHoliday == "21-23")
                    {
                        priceForASingleNight = 32;
                    }
                    else if (periodOfTheHoliday == "24-27")
                    {
                        priceForASingleNight = 37;
                    }
                    else if (periodOfTheHoliday == "28-31")
                    {
                        priceForASingleNight = 43;
                    }
                    break;              
            }
            double holidayPrice = priceForASingleNight * sleepOversCount;

            Console.WriteLine($"Easter trip to {destination} : {holidayPrice:F2} leva.");
        }
    }
}
