﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numCount; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }

            Console.WriteLine(sum);

        }
    }
}