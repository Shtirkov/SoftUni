using P04.Recharge.Interfaces;
using P04.Recharge.Models;
using System;
using System.Collections.Generic;

namespace P04.Recharge
{
    public class StartUp
    {
        static void Main()
        {
            var employee = new Employee("Pesho");
            var robot = new Robot("MS-13", 100);
            var employees = new List<IWorker> { employee, robot };

            employees.ForEach(employee => employee.Work(8));
            employee.Sleep();
            Console.WriteLine(robot.Capacity);
            Console.WriteLine(robot.CurrentPower);
            robot.Recharge();
            Console.WriteLine(robot.CurrentPower);
            employees.ForEach(employee => employee.Work(8));
            Console.WriteLine(robot.CurrentPower);
        }
    }
}
