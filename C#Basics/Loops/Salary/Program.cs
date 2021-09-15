using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openBrowserTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openBrowserTabs; i++)
            {
                string webSiteName = Console.ReadLine();
               
                if (webSiteName == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (webSiteName == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (webSiteName =="Reddit")
                {
                    salary = salary - 50;
                }
            }
            if (salary <=0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
