﻿namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; set; }

        public override string ToString() => $"{FirstName} {LastName} receives {Salary.ToString("f2")} leva.";

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += Salary * (percentage / 200);
            }
            else 
            {
                Salary += Salary * (percentage / 100);
            }
        }
    }
}
