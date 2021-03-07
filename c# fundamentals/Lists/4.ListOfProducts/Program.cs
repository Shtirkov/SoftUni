using System;
using System.Collections.Generic;

namespace _4.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            SortAStringArrayAlpabetically(numberOfStrings);
        }

        static void SortAStringArrayAlpabetically(int numberOfStrings)
        {

            List<string> stringsToSort = new List<string>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                //List<string> productsToSort = new List<string>();
                string product = Console.ReadLine();

                stringsToSort.Add(product);
            }

            stringsToSort.Sort();

            for (int i = 0; i < stringsToSort.Count; i++)
            {
                Console.WriteLine($"{i+1}.{stringsToSort[i]}");
            }
        }
    }
}
