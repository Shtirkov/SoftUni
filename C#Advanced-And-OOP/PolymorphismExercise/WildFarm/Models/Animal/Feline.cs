using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
   public abstract class Feline : Animal
    {
        public Feline(string name, double weight, string breed) 
            : base(name, weight)
        {
            this.Breed = breed;
        }

        public string Breed { get;}
    }
}
