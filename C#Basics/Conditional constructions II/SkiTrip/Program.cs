using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double totalPrice;

            if (roomType == "room for one person" && days < 10 && rating == "positive")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "room for one person" && days < 10 && rating == "negative")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice - totalPrice * 0.1:F2}");
            }
            else if (roomType == "room for one person" && days >= 10 && days <= 15 && rating == "negative")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice - totalPrice * 0.1:F2}");
            }
            else if (roomType == "room for one person" && days >= 10 && days <= 15 && rating == "positive")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "room for one person" && days > 15 && rating == "negative")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice - totalPrice * 0.10:F2}");
            }
            else if (roomType == "room for one person" && days > 15 && rating == "positive")
            {
                totalPrice = (days - 1) * 18;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "apartment" && days < 10 && rating == "negative")
            {
                totalPrice = ((days - 1) * 25) * 0.7;
                Console.WriteLine($"{totalPrice - totalPrice * 0.1:F2}");
            }
            else if (roomType == "apartment" && days < 10 && rating == "positive")
            {
                totalPrice = ((days - 1) * 25) * 0.7;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "apartment" && days >= 10 && days <= 15 && rating == "negative")
            {
                totalPrice = ((days - 1) * 25) * 0.65;
                Console.WriteLine($"{totalPrice - totalPrice * 0.10:F2}");
            }
            else if (roomType == "apartment" && days >= 10 && days <= 15 && rating == "positive")
            {
                totalPrice = ((days - 1) * 25) * 0.65;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "apartment" && days > 15 && rating == "negative")
            {
                totalPrice = ((days - 1) * 25) * 0.5;
                Console.WriteLine($"{totalPrice - totalPrice * 0.10:F2}");
            }
            else if (roomType == "apartment" && days > 15 && rating == "positive")
            {
                totalPrice = ((days - 1) * 25) * 0.5;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "president apartment" && days < 10 && rating == "negative")
            {
                totalPrice = ((days - 1) * 35) * 0.9;
                Console.WriteLine($"{totalPrice - totalPrice * 0.1:F2}");
            }
            else if (roomType == "president apartment" && days < 10 && rating == "positive")
            {
                totalPrice = ((days - 1) * 35) * 0.9;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "president apartment" && days >= 10 && days <= 15 && rating == "negative")
            {
                totalPrice = ((days - 1) * 35) * 0.85;
                Console.WriteLine($"{totalPrice - totalPrice * 0.10:F2}");
            }
            else if (roomType == "president apartment" && days >= 10 && days <= 15 && rating == "positive")
            {
                totalPrice = ((days - 1) * 35) * 0.85;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
            else if (roomType == "president apartment" && days >15 && rating == "negative")
            {
                totalPrice = ((days - 1) * 35) * 0.80;
                Console.WriteLine($"{totalPrice - totalPrice * 0.10:F2}");
            }
            else if (roomType == "president apartment" && days > 15 && rating == "positive")
            {
                totalPrice = ((days - 1) * 35) * 0.80;
                Console.WriteLine($"{totalPrice + totalPrice * 0.25:F2}");
            }
        }
    }
}
