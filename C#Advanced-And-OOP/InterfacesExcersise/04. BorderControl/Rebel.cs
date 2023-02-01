using System;
using System.Collections.Generic;
using System.Text;

namespace _04._BorderControl
{
    public class Rebel : IBuyer
    {
        private int totalFood = 0;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get;}

        public int Age { get;}

        public string Group { get;}
        public int Food { get; set; }

        public int BuyFood()
        {
            return 5;
        }
    }
}
