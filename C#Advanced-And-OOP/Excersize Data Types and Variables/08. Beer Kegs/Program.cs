using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestKegModel = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                double kegHeight = double.Parse(Console.ReadLine());

                double kegVolume = 3.14 * kegRadius * kegRadius * kegHeight;
                if (kegVolume > biggestKeg)
                {
                    biggestKegModel = kegModel;
                    biggestKeg = kegVolume;
                }
                kegVolume = 0;
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
