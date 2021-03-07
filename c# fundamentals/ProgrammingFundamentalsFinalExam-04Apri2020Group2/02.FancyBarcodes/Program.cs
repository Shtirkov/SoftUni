using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < barcodesCount; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
                Regex regex = new Regex(pattern);
                MatchCollection validBarcodes = regex.Matches(input);

                if (validBarcodes.Count>0)
                {
                    string productGroup = string.Empty;

                    for (int k = 0; k < input.Length; k++)
                    {
                        if (char.IsDigit(input[k]))
                        {
                            productGroup += input[k];
                        }
                    }

                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

            
        }
    }
}
