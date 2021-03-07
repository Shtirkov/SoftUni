using System;

namespace DogNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Drake", "Buster", "Nero" };
            Random random = new Random();
            int start2 = random.Next(0, 2);
            Console.Write(names[start2]);
        }
    }
}
