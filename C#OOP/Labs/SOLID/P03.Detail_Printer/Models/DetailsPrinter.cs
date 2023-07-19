using System.Collections.Generic;

namespace P03.Detail_Printer.Models
{
    public class DetailsPrinter
    {
        private ICollection<Employee> employees;

        public DetailsPrinter(ICollection<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (Employee employee in employees)
            {
                employee.PrintDetails();
            }
        }       
    }
}
