using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPRice = 0;
            
                if (month == "May" || month == "October")
                {
                    studioPrice = 50;
                    apartmentPRice = 65;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20;
                    apartmentPRice = 68.70;
                }
                else if (month == "July" || month == "August")
                {
                    studioPrice = 76;
                    apartmentPRice = 77;
                }
                if ((nightsCount > 7 && nightsCount <= 14 && month == "May") || (nightsCount > 7 && nightsCount <= 14 && month == "October"))
                {
                    studioPrice = 0.95 * studioPrice;
                }
                else if ((nightsCount > 14 && month == "May") ||  (nightsCount > 14 &&month == "October"))
                {
                    studioPrice = 0.70 * studioPrice;
                }
                else if ((nightsCount > 14 && month == "June") || (nightsCount > 14 && month == "September"))
                {
                    studioPrice = 0.80 * studioPrice;
                }
                if (nightsCount > 14)
                {
                    apartmentPRice = 0.90 * apartmentPRice;
                }
                Console.WriteLine($"Apartment: {apartmentPRice * nightsCount:f2} lv.");
                Console.WriteLine($"Studio: {studioPrice * nightsCount:f2} lv.");
            }
        }
    }

