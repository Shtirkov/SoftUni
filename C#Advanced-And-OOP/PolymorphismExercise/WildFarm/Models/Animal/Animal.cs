using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animal.Contracts;

namespace WildFarm.Models.Animal
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;            
        }

        public string Name { get;}

        public double Weight { get;}

        public int FoodEaten { get;}

        public abstract void Eat();
       

        public abstract string ProduceSound();        
    }
}
