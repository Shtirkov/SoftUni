using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var animal = Console.ReadLine();

            while (animal != "Beast!")
            {
                var animalInfo = Console.ReadLine().Split();
                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                var gender = animalInfo[2];

                switch (animal)
                {
                    case "Cat":
                        animals.Add(new Cat(name, age, gender));
                        break;
                    case "Dog":
                        animals.Add(new Dog(name, age, gender));
                        break;
                    case "Frog":
                        animals.Add(new Frog(name, age, gender));
                        break;
                    case "Kitten":
                        animals.Add(new Kitten(name, age));
                        break;
                    case "Tomcat":
                        animals.Add(new Tomcat(name, age));
                        break;
                }

                animal = Console.ReadLine();
            }

            animals.ForEach(animal => Console.WriteLine(animal));
        }
    }
}
