using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookShelfCapacity = int.Parse(Console.ReadLine());
            bool isBookFound = false;
            int counter = 0;

            while (counter < bookShelfCapacity)
            {
                string nextBookName = Console.ReadLine();

                if (nextBookName == book)
                {
                    isBookFound = true;
                    break;
                }

                counter++;
            }

            if (counter == bookShelfCapacity)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookShelfCapacity} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }

        }
    }
}
