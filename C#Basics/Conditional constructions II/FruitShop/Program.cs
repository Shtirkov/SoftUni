using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if((day == "Monday" || day=="Tuesday" || day =="Wednesday" || day=="Thursday" || day=="Friday") && fruit == "banana")
            {
                Console.WriteLine($"{quantity * 2.50:F2}"); 
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "apple")
            {
                Console.WriteLine($"{quantity * 1.20:F2}");
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "orange")
            {
                Console.WriteLine($"{quantity * 0.85:F2}");
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "grapefruit")
            {
                Console.WriteLine($"{quantity * 1.45:F2}");
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "kiwi")
            {
                Console.WriteLine($"{quantity * 2.70:F2}");
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "pineapple")
            {
                Console.WriteLine($"{quantity * 5.50:F2}");
            }
            else if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") && fruit == "grapes")
            {
                Console.WriteLine($"{quantity * 3.85:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "banana")
            {
                Console.WriteLine($"{quantity * 2.70:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "apple")
            {
                Console.WriteLine($"{quantity * 1.25:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "orange")
            {
                Console.WriteLine($"{quantity * 0.90:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "grapefruit")
            {
                Console.WriteLine($"{quantity * 1.60:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "kiwi")
            {
                Console.WriteLine($"{quantity * 3.00:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "pineapple")
            {
                Console.WriteLine($"{quantity * 5.60:F2}");
            }
            else if ((day == "Saturday" || day == "Sunday") && fruit == "grapes")
            {
                Console.WriteLine($"{ quantity * 4.20:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
