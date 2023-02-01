using System;

namespace Padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfSingleLightsaber = double.Parse(Console.ReadLine());
            double priceOfSingleRobe = double.Parse(Console.ReadLine());
            double priceOfSingleBelt = double.Parse(Console.ReadLine());

            double priceForAllLightsabers = Math.Ceiling(studentsCount * 1.1) * priceOfSingleLightsaber;
            double priceOfAllBelts = 0;
            double priceOfAllRobes = studentsCount * priceOfSingleRobe;

            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 6 ==0)
                {
                    continue;
                }
                priceOfAllBelts += priceOfSingleBelt;
            }

            double totalPrice = priceForAllLightsabers + priceOfAllBelts + priceOfAllRobes;

            if (availableMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - availableMoney:f2}lv more.");
            }
        }
    }
}
