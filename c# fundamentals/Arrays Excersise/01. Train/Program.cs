using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] people = new int[wagonsCount];
            int sum = 0;
            for (int i = 0; i < wagonsCount; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write($"{people[i]} ");
            }

            Console.WriteLine("");
            Console.WriteLine(sum);
        }
    }
}
