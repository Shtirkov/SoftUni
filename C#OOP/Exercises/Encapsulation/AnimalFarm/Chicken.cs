﻿namespace AnimalFarm
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;
        private const string InvalidNameExceptionMessage = "Name cannot be empty.";
        private const string InvalidAgeExceptionMessage = "Age should be between 0 and 15.";

        private string _name;
        private int _age;

        internal Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => _name;
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidNameExceptionMessage);
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {

                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException(InvalidAgeExceptionMessage);
                }
                _age = value;
            }
        }

        public double ProductPerDay => CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            switch (Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}