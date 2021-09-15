using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int rows = 1; rows <= number; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{counter} ");
                    counter++;

                    if (counter == number + 1)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
