using _04._BorderControl;
using System;
using System.Collections.Generic;

namespace _05.Bithday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<IBuyer> buyers = new List<IBuyer>();
            int totalFood = 0;

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 4)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];
                    string birthDate = data[3];

                    Citizen citizen = new Citizen(name, age, id, birthDate);
                    buyers.Add(citizen);
                }
                else if (data.Length == 3)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string group = data[2];

                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            string personName = Console.ReadLine();

            while (personName != "End")
            {
                foreach (var unit in buyers)
                {
                    Type unitType = unit.GetType();
                    if (unitType.Name == "Citizen")
                    {
                        Citizen c = (Citizen)unit;
                        if (personName == c.Name)
                        {                         
                            totalFood += c.BuyFood();
                        }
                    }
                    else if (unitType.Name == "Rebel")
                    {
                        Rebel r = (Rebel)unit;
                        if (personName == r.Name)
                        {
                            totalFood += r.BuyFood();
                        }
                    }
                }
                personName = Console.ReadLine();
            }

            Console.WriteLine(totalFood);

           
        }
    }
}

