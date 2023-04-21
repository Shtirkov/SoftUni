using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string _errorMessage = "Invalid input!";
        private string _name;
        private int _age;
        private string _gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(_errorMessage);
                }

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(_errorMessage);
                }

                _age = value;
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException(_errorMessage);
                }
               
                _gender = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendLine(GetType().Name);
            output.AppendLine($"{Name} {Age} {Gender}");
            output.AppendLine(ProduceSound());

            return output.ToString();
        }

        public abstract string ProduceSound();
    }
}
