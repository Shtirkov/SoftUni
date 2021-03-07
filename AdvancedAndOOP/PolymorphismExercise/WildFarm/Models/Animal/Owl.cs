using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animal;

namespace WildFarm.Models.Food
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot"; 
        }
    }
}
