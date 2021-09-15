using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal.Contracts
{
   public interface IAnimal
    {
        public string ProduceSound();

        public void Eat();
    }
}
