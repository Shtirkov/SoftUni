using P03.Detail_Printer.Models;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class StartUp
    {
        static void Main()
        {
            var employees = new List<Employee> { new Employee("Ivan"), new Manager("Pesho", new List<string> { "Doc1", "Doc2", "Doc3" }) };
            var printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
