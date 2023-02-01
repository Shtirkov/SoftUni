using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double finalResult = 0;
            string finalResultType = "";
            
            if (action == "+")
            {
                finalResult = n1 + n2;
            }
            else if (action == "-")
            {
                finalResult = n1 - n2;
            }
            else if (action == "*")
            {
                finalResult = n1 * n2;
            }
            else if (action == "/" && n2 != 0)
            {
                finalResult = n1 / n2;
            }
            else if (action == "%" && n2 !=0)
            {
                finalResult = n1 % n2;
            }
            if (finalResult % 2 != 0 && (action == "+" || action == "-" || action == "*"))
            {
                finalResultType = "odd";
            }
            else if (finalResult % 2 == 0 && (action == "+" || action == "-" || action == "*"))
            {
                finalResultType = "even";
            }
            if (action == "+" || action == "-" || action == "*")
            {
                Console.WriteLine($"{n1} {action} {n2} = {finalResult} - {finalResultType}");
            }
            else if (action == "/" && n2 != 0)
            {
                Console.WriteLine($"{n1} / {n2} = {finalResult:f2}");
            }
            else if (action == "%" && n2 !=0)
            {
                Console.WriteLine($"{n1} % {n2} = {finalResult}");
            }
            else if (action == "/" || action =="%" && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
        }
    }
}
