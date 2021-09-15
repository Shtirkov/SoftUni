using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minZaplata = double.Parse(Console.ReadLine());
            double socStipendiq = 0.35 * minZaplata;
            double stipendiq = sredenUspeh * 25;

            if (dohod < minZaplata && sredenUspeh > 4.5 && sredenUspeh < 5.5)
            {
                // socStipendiq = 0.35 * minZaplata;
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socStipendiq)} BGN");
            }
            else if (dohod < minZaplata && sredenUspeh > 5.5 && socStipendiq > stipendiq)
            {
                //socStipendiq = 0.35 * minZaplata;
                //stipendiq = sredenUspeh * 25;
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socStipendiq)} BGN");
            }
            else if (dohod < minZaplata && sredenUspeh > 5.5 && stipendiq > socStipendiq)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(stipendiq)} BGN");
            }
            else if (dohod < minZaplata && sredenUspeh > 5.5 && stipendiq == socStipendiq)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(stipendiq)} BGN");
            }
            else if (sredenUspeh >= 5.5)
            {
                // stipendiq = sredenUspeh * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(stipendiq)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
