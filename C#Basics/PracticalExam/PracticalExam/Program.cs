using System;

namespace PracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouveniers = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());
            double moneyForFuel = 54.39;
            double totalNeededMoney = 0;
            double hotelPriceForFirstNight = 0;
            double hotelPriceForSecondNight = 0;
            double hotelPriceForThirdNight = 0;            
            double totalNeededMoneyForHotel = 0;

            for (int nightsCounter = 1; nightsCounter <= 3; nightsCounter++)
            {
                if (nightsCounter == 1)
                {
                    hotelPriceForFirstNight = moneyForHotel * 0.9;                   
                }
                else if (nightsCounter == 2)
                {
                    hotelPriceForSecondNight = moneyForHotel * 0.85;                  
                }
                else if (nightsCounter == 3)
                {
                    hotelPriceForThirdNight = moneyForHotel * 0.8;
                }

            }
            totalNeededMoneyForHotel = hotelPriceForFirstNight + hotelPriceForSecondNight + hotelPriceForThirdNight;
            totalNeededMoney = (moneyForFood + moneyForSouveniers) * 3;
            Console.WriteLine($"Money needed: {totalNeededMoney + totalNeededMoneyForHotel+ moneyForFuel:f2}");
        }
    }
}
