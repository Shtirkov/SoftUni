using System;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyNeedeForTheSinger = int.Parse(Console.ReadLine());
            string numberOfPeopleInGroup = Console.ReadLine();
            int couvertPrice = 0;
            int totalPrice = 0;
            int totalPeople = 0;

            while (numberOfPeopleInGroup != "The restaurant is full")
            {               
                int newPeople = int.Parse(numberOfPeopleInGroup);

                if (newPeople >= 5)
                {
                    couvertPrice = newPeople * 70;
                    totalPeople += newPeople;
                }
                else if (newPeople<5)
                {
                    couvertPrice = newPeople * 100;
                    totalPeople += newPeople;
                }
                totalPrice += couvertPrice;
                numberOfPeopleInGroup = Console.ReadLine();
            }           

            if (totalPrice >= moneyNeedeForTheSinger)
            {
                Console.WriteLine($"You have {totalPeople} guests and {(moneyNeedeForTheSinger - totalPrice) * -1} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalPeople} guests and {totalPrice} leva income, but no singer.");
            }
        }
    }
}
