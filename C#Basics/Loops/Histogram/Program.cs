using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumbersCount = int.Parse(Console.ReadLine());
            double lessThan200 = 0;
            double between200and399 = 0;
            double between400and599 = 0;
            double between600and799 = 0;
            double biggerThan800 = 0;

            for (int i = 1; i <= userNumbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    lessThan200++;
                }
                else if (currentNumber >= 200 && currentNumber <= 399)
                {
                    between200and399++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    between400and599++;
                }
                else if (currentNumber >=600 && currentNumber<=799)
                {
                    between600and799++;
                }
                else
                {
                    biggerThan800++;
                }
            }
            double p1 = (lessThan200 / userNumbersCount) * 100;
            double p2 = (between200and399 / userNumbersCount) * 100;
            double p3 = (between400and599 / userNumbersCount) * 100;
            double p4 = (between600and799 / userNumbersCount) * 100;
            double p5 = (biggerThan800 / userNumbersCount) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
