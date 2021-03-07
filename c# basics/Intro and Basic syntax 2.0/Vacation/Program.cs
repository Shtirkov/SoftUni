using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfThePeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;

            if (groupType == "Students" && dayOfWeek == "Friday")
            {
                pricePerPerson = 8.45;
            }
            else if (groupType == "Students" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 9.80;
            }
            else if (groupType == "Students" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 10.46;
            }
            else if (groupType == "Business" && dayOfWeek == "Friday")
            {
                pricePerPerson = 10.90;
            }
            else if (groupType == "Business" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 15.60;
            }
            else if (groupType == "Business" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 16;
            }
            else if (groupType == "Regular" && dayOfWeek == "Friday")
            {
                pricePerPerson = 15;
            }
            else if (groupType == "Regular" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 20;
            }
            else if (groupType == "Regular" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 22.50;
            }

            if (groupType == "Students" && countOfThePeople >= 30)
            {
                totalPrice = (countOfThePeople * pricePerPerson) * 0.85;
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (groupType == "Students" && countOfThePeople <= 30)
            {
                Console.WriteLine($"Total price: {countOfThePeople * pricePerPerson:f2}");
            }

            if (groupType == "Business" && countOfThePeople >= 100)
            {
                totalPrice = (countOfThePeople - 10) * pricePerPerson;
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (groupType == "Business" && countOfThePeople <= 100)
            {
                Console.WriteLine($"Total price: {countOfThePeople * pricePerPerson:f2}");
            }

            if ((groupType == "Regular") && countOfThePeople >= 10 && countOfThePeople <= 20)
            {
                totalPrice = (countOfThePeople * pricePerPerson) * 0.95;
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if ((groupType == "Regular") && countOfThePeople < 10 )
            {                
                Console.WriteLine($"Total price: {countOfThePeople * pricePerPerson:f2}");
            }
            else if ((groupType == "Regular") && countOfThePeople > 20)
            {
                Console.WriteLine($"Total price: {countOfThePeople * pricePerPerson:f2}");
            }
        }
    }
}
