using System;

namespace _04._Printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangleTo(n);
        }

        static void PrintTriangleTo(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    //Console.Write($"{k} ");
                    if (k == i)
                    {
                        Console.WriteLine(k);
                        break;
                    }
                    Console.Write($"{k} ");
                }
            }

            for (int i = number; i > 0; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    if (k == i - 1)
                    {
                        Console.WriteLine(k);
                        break;
                    }
                    Console.Write($"{k} ");
                }
            }
        }
    }
}
