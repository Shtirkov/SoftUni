using System;
using System.Linq;

namespace _05._FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ");
                var name = data[0];
                var parsedAge = int.Parse(data[1]);
                people[i] = new Person(name, parsedAge);
            }


            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person[], int, string, Person[]> filterPeople = FilterByAge;
            Action<Person[], string> printPeople = PrintPeople;
            people = filterPeople(people, age, condition);
            printPeople(people, format);

        }

        static Person[] FilterByAge(Person[] people, int age, string condition)
        {
            switch (condition)
            {
                case "younger":
                    return  people = people.Where(x => x.Age < age).ToArray();
                case "older":
                    return people = people.Where(x => x.Age >= age).ToArray();
                default:
                    return null;
            }
        }

        static void PrintPeople(Person[] people, string format)
        {
            switch (format)
            {
                case "name":
                    foreach (var person in people)
                    {
                        Console.WriteLine(person.Name);
                    }                    
                break;
                case "age":
                    foreach (var person in people)
                    {
                        Console.WriteLine(person.Age);
                    }
                    break;
                case "name age":
                    foreach (var person in people)
                    {
                        Console.WriteLine($"{person.Name} - {person.Age}");
                    }
                    break;
                default:
                    break;
            }
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        
    }
}
