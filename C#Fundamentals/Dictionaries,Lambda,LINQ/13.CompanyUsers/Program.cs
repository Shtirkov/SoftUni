using System;
using System.Collections.Generic;

namespace _13.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string companyName = input.Split(" -> ")[0];
                string employeeID = input.Split(" -> ")[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeID);
                }
                else
                {
                    if (!companies[companyName].Contains(employeeID))
                    {
                        companies[companyName].Add(employeeID);
                    }
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                for (int i = 0; i < company.Value.Count; i++)
                {
                    Console.WriteLine($"-- {company.Value[i]}");
                }
            }
        }
    }
}
